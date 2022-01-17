import React from "react";

export default function Saludar(props){

    return(
        <div>
            <h2>Hola {props.name}, {props.edad} años</h2>
        </div>
    )
}

export function SaludarUser(props){
    return(
        <div>
            <h2>Hola {props.userInfo.name}, {props.userInfo.age} años</h2>
        </div>
    )
}

