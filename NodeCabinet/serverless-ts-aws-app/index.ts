export const handler = async(event: any) => {
    console.log(event)

    return{
        status:200,
        body: JSON.stringify({message: 'Hello world'})
    }
}
