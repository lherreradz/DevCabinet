import react from "react";
import { TextInput, View, Button } from "react-native";

export default function LoginForm() {
  return (
    <View>
      <TextInput placeholder="Email" />
      <TextInput placeholder="Password" />
      <Button title="Submit" onPress={console.log("enviar")} />
    </View>
  );
}
