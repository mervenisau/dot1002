void PlaySound(AudioClip soundClip)
{
    AudioSource audioSource = GetComponent<AudioSource>();
    audioSource.clip = soundClip;
    audioSource.Play();
}

void Jump()
{
    PlaySound(jumpSound);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot()
{
    PlaySound(shootSound);
    Instantiate(bullet);
}