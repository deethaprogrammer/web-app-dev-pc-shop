export default function Login(){
    return(
        <div className="min-h-screen flex items-center justify-center bg-olive-300 p-4">
            <div className="w-full max-w-md rounded-2xl bg-olive-400 p-10 shadow-sm">
                <h1 className="text-4xl text-center">
                    Login with your account
                </h1>

                <form className="flex flex-col gap-2">
                    <label className="mt-4">
                        E-mailadres
                    </label>
                    <input type="email" className="border-2 border-b-black rounded-sm"/>

                    <label className="">
                        Password
                    </label>
                    <input type="password" className="border-2 border-b-black rounded-sm"/>

                    <button type="submit" className="mt-5 rounded-lg bg-olive-700 text-lg font-semibold text-white shadow transition-colors hover:bg-olive-800">
                        Log in
                    </button>
                </form>
            </div>
        </div>
    )
}