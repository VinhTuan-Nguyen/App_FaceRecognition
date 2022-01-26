from keras import activations
from sklearn.model_selection import train_test_split
from keras.applications.vgg16 import VGG16
from keras.layers import Input, Flatten, Dense, Dropout
from keras.models import Model, Sequential
from keras.callbacks import ModelCheckpoint
from keras.preprocessing.image import ImageDataGenerator
import pickle


def load_data():
    with open('/content/train112.data', 'rb') as file:
        data = pickle.load(file)
        file.close()
    return data


def get_model(num_class):
    vgg16 = VGG16(weights='imagenet', include_top=False, input_shape=(112, 112, 3))
    vgg16.summary()

    for layer in vgg16.layers:
        layer.trainable = False

    my_model = Sequential()
    my_model.add(vgg16)
    my_model.summary()

    my_model.add(Flatten(name='Flatten'))
    my_model.add(Dense(4096, activation='relu', name='fc1'))
    my_model.add(Dropout(0.5))
    my_model.add(Dense(4096, activation='relu', name='fc2'))
    my_model.add(Dropout(0.5))
    my_model.add(Dense(num_class, activation='softmax', name='predictions'))
    my_model.summary()

    my_model.compile(loss='categorical_crossentropy',
                     optimizer='adam', metrics=['accuracy'])

    return my_model


def train_model():
    # Load data
    data = load_data()
    # Gán data
    class_labels = data[0]
    labels, pixels = data[1]
    # Load model và tạo checkpoint để lưu lại weights có accuracy cao nhất
    vggmodel = get_model(len(class_labels))
    filepath = '/content/models/weights-{epoch:02d}-{val_accuracy:.2f}.hdf5'
    checkpoint = ModelCheckpoint(filepath, monitor='val_accuracy',
                                 verbose=1, save_best_only=True, mode='max')
    # Chia tập dữ liệu
    X_train, X_test, y_train, y_test = train_test_split(
        pixels, labels, test_size=0.2, random_state=100)
    # Train model
    aug = ImageDataGenerator(rotation_range=20, zoom_range=0.1, rescale=1. / 255,
                             width_shift_range=0.1, height_shift_range=0.1,
                             horizontal_flip=True, brightness_range=[0.2, 1.5],
                             fill_mode='nearest')
    vggmodel.fit_generator(aug.flow(X_train, y_train, batch_size=64), epochs=50,
                           validation_data=aug.flow(X_test, y_test, batch_size=64),
                           callbacks=[checkpoint])
    vggmodel.save('/content/models/model.h5')


train_model()
