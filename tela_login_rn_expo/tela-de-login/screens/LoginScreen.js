import {
  View,
  Text,
  StyleSheet,
  TextInput,
  Touchable,
  TouchableOpacity,
} from "react-native";
import React from "react";

export default function LoginScreen() {
  return (
    <View style={styles.screen}>
      <View style={styles.loginContainer}>
        <View style={styles.login}>
          <Text style={styles.loginWords}>Login</Text>
        </View>

        <View style={styles.inputContainer}>
          <TextInput placeholder="Login" style={styles.input} />
          <TextInput placeholder="Senha" style={styles.input} secureTextEntry />
        </View>
        <View>
          <TouchableOpacity style={styles.botao}>
            <Text>Login</Text>
          </TouchableOpacity>
        </View>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    backgroundColor: "#008071",
    alignItems: "center",
    justifyContent: "center",
  },
  loginContainer: {
    alignItems: "center",
  },
  login: {
    alignItems: "center",
    justifyContent: "center",
  },
  loginWords: {
    fontWeight: "bold",
    fontSize: 50,
  },
  inputContainer: {
    marginTop: 20,
    width: 300,
    gap: 10,
  },
  input: {
    borderWidth: 1,
    borderColor: "black",
    padding: 10,
    borderRadius: 5,
    backgroundColor: "white",
  },
  botao: {
    margin: 10,
    backgroundColor: "white",
    width: 200,
    height: 40,
    alignItems: "center",
    justifyContent: "center",
    borderRadius: 30,
    borderStyle: "solid",
    borderColor: "black",
    borderWidth: 2,
  },
});
