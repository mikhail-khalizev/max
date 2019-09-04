using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_320e-97dd03d3")]
        public void Method_1009_320e()
        {
            ii(0x1009_320e, 5);  push(0x90);                           /* push 0x90 */
            ii(0x1009_3213, 5);  call(Definitions.sys_check_available_stack_size, 0xd_2b3a);/* call 0x10165d52 */
            ii(0x1009_3218, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_3219, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_321a, 1);  push(edx);                            /* push edx */
            ii(0x1009_321b, 1);  push(esi);                            /* push esi */
            ii(0x1009_321c, 1);  push(edi);                            /* push edi */
            ii(0x1009_321d, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_321e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_3220, 6);  sub(esp, 0x74);                       /* sub esp, 0x74 */
            ii(0x1009_3226, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_3229, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1009_322e, 5);  call(0x1007_5fdc, -0x1_d257);         /* call 0x10075fdc */
            ii(0x1009_3233, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_3236, 2);  if(jl(0x1009_328d, 0x55)) goto l_0x1009_328d;/* jl 0x1009328d */
            ii(0x1009_3238, 5);  mov(eax, 0x23);                       /* mov eax, 0x23 */
            ii(0x1009_323d, 5);  call(0x100c_dec2, 0x3_ac80);          /* call 0x100cdec2 */
            ii(0x1009_3242, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_3244, 2);  if(jz(0x1009_328d, 0x47)) goto l_0x1009_328d;/* jz 0x1009328d */
            ii(0x1009_3246, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x1009_324b, 5);  call(Definitions.sys_new, 0xd_2bb0);  /* call 0x10165e00 */
            ii(0x1009_3250, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1009_3253, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_3256, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1009_3259, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1009_325d, 2);  if(jz(0x1009_327a, 0x1b)) goto l_0x1009_327a;/* jz 0x1009327a */
            ii(0x1009_325f, 5);  mov(ebx, 0x23);                       /* mov ebx, 0x23 */
            ii(0x1009_3264, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3267, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1009_326a, 5);  call(Definitions.my_ctor_c4, 0x63f3); /* call 0x10099662 */
            ii(0x1009_326f, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1009_3272, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1009_3275, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_3278, 2);  jmp(0x1009_3280, 6); goto l_0x1009_3280;/* jmp 0x10093280 */
        l_0x1009_327a:
            ii(0x1009_327a, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1009_327d, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
        l_0x1009_3280:
            ii(0x1009_3280, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x1009_3283, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3288, 5);  call(0x100a_4d50, 0x1_1ac3);          /* call 0x100a4d50 */
        l_0x1009_328d:
            ii(0x1009_328d, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1009_3292, 5);  call(0x1007_5fdc, -0x1_d2bb);         /* call 0x10075fdc */
            ii(0x1009_3297, 3);  cmp(eax, 1);                          /* cmp eax, 0x1 */
            ii(0x1009_329a, 2);  if(jl(0x1009_32f1, 0x55)) goto l_0x1009_32f1;/* jl 0x100932f1 */
            ii(0x1009_329c, 5);  mov(eax, 0x22);                       /* mov eax, 0x22 */
            ii(0x1009_32a1, 5);  call(0x100c_dec2, 0x3_ac1c);          /* call 0x100cdec2 */
            ii(0x1009_32a6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_32a8, 2);  if(jz(0x1009_32f1, 0x47)) goto l_0x1009_32f1;/* jz 0x100932f1 */
            ii(0x1009_32aa, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x1009_32af, 5);  call(Definitions.sys_new, 0xd_2b4c);  /* call 0x10165e00 */
            ii(0x1009_32b4, 3);  mov(memd[ss, ebp - 64], eax);         /* mov [ebp-0x40], eax */
            ii(0x1009_32b7, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_32ba, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x1009_32bd, 4);  cmp(memd[ss, ebp - 68], 0);           /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1009_32c1, 2);  if(jz(0x1009_32de, 0x1b)) goto l_0x1009_32de;/* jz 0x100932de */
            ii(0x1009_32c3, 5);  mov(ebx, 0x22);                       /* mov ebx, 0x22 */
            ii(0x1009_32c8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_32cb, 3);  mov(eax, memd[ss, ebp - 64]);         /* mov eax, [ebp-0x40] */
            ii(0x1009_32ce, 5);  call(Definitions.my_ctor_c4, 0x638f); /* call 0x10099662 */
            ii(0x1009_32d3, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x1009_32d6, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1009_32d9, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1009_32dc, 2);  jmp(0x1009_32e4, 6); goto l_0x1009_32e4;/* jmp 0x100932e4 */
        l_0x1009_32de:
            ii(0x1009_32de, 3);  mov(eax, memd[ss, ebp - 68]);         /* mov eax, [ebp-0x44] */
            ii(0x1009_32e1, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
        l_0x1009_32e4:
            ii(0x1009_32e4, 3);  mov(edx, memd[ss, ebp - 60]);         /* mov edx, [ebp-0x3c] */
            ii(0x1009_32e7, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_32ec, 5);  call(0x100a_4d50, 0x1_1a5f);          /* call 0x100a4d50 */
        l_0x1009_32f1:
            ii(0x1009_32f1, 5);  mov(eax, 0x4c);                       /* mov eax, 0x4c */
            ii(0x1009_32f6, 5);  call(0x1007_5fdc, -0x1_d31f);         /* call 0x10075fdc */
            ii(0x1009_32fb, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1009_32fe, 2);  if(jl(0x1009_3355, 0x55)) goto l_0x1009_3355;/* jl 0x10093355 */
            ii(0x1009_3300, 5);  mov(eax, 0x25);                       /* mov eax, 0x25 */
            ii(0x1009_3305, 5);  call(0x100c_dec2, 0x3_abb8);          /* call 0x100cdec2 */
            ii(0x1009_330a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_330c, 2);  if(jz(0x1009_3355, 0x47)) goto l_0x1009_3355;/* jz 0x10093355 */
            ii(0x1009_330e, 5);  mov(eax, 0x19);                       /* mov eax, 0x19 */
            ii(0x1009_3313, 5);  call(Definitions.sys_new, 0xd_2ae8);  /* call 0x10165e00 */
            ii(0x1009_3318, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x1009_331b, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1009_331e, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x1009_3321, 4);  cmp(memd[ss, ebp - 84], 0);           /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1009_3325, 2);  if(jz(0x1009_3342, 0x1b)) goto l_0x1009_3342;/* jz 0x10093342 */
            ii(0x1009_3327, 5);  mov(ebx, 0x25);                       /* mov ebx, 0x25 */
            ii(0x1009_332c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_332f, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x1009_3332, 5);  call(Definitions.my_ctor_c4, 0x632b); /* call 0x10099662 */
            ii(0x1009_3337, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x1009_333a, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x1009_333d, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x1009_3340, 2);  jmp(0x1009_3348, 6); goto l_0x1009_3348;/* jmp 0x10093348 */
        l_0x1009_3342:
            ii(0x1009_3342, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x1009_3345, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
        l_0x1009_3348:
            ii(0x1009_3348, 3);  mov(edx, memd[ss, ebp - 76]);         /* mov edx, [ebp-0x4c] */
            ii(0x1009_334b, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3350, 5);  call(0x100a_4d50, 0x1_19fb);          /* call 0x100a4d50 */
        l_0x1009_3355:
            ii(0x1009_3355, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1009_335a, 5);  call(Definitions.sys_new, 0xd_2aa1);  /* call 0x10165e00 */
            ii(0x1009_335f, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1009_3362, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_3365, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1009_3368, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1009_336c, 2);  if(jz(0x1009_3384, 0x16)) goto l_0x1009_3384;/* jz 0x10093384 */
            ii(0x1009_336e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3371, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1009_3374, 5);  call(Definitions.my_ctor_c5, 0x659f); /* call 0x10099918 */
            ii(0x1009_3379, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1009_337c, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1009_337f, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x1009_3382, 2);  jmp(0x1009_338a, 6); goto l_0x1009_338a;/* jmp 0x1009338a */
        l_0x1009_3384:
            ii(0x1009_3384, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1009_3387, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
        l_0x1009_338a:
            ii(0x1009_338a, 3);  mov(edx, memd[ss, ebp - 96]);         /* mov edx, [ebp-0x60] */
            ii(0x1009_338d, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3392, 5);  call(0x100a_4d50, 0x1_19b9);          /* call 0x100a4d50 */
            ii(0x1009_3397, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1009_339c, 5);  call(Definitions.sys_new, 0xd_2a5f);  /* call 0x10165e00 */
            ii(0x1009_33a1, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_33a4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_33a7, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_33aa, 4);  cmp(memd[ss, ebp - 24], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1009_33ae, 2);  if(jz(0x1009_33c6, 0x16)) goto l_0x1009_33c6;/* jz 0x100933c6 */
            ii(0x1009_33b0, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_33b3, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_33b6, 5);  call(Definitions.my_ctor_c6, 0x67cd); /* call 0x10099b88 */
            ii(0x1009_33bb, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_33be, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1009_33c1, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x1009_33c4, 2);  jmp(0x1009_33cc, 6); goto l_0x1009_33cc;/* jmp 0x100933cc */
        l_0x1009_33c6:
            ii(0x1009_33c6, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_33c9, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
        l_0x1009_33cc:
            ii(0x1009_33cc, 3);  mov(edx, memd[ss, ebp - 92]);         /* mov edx, [ebp-0x5c] */
            ii(0x1009_33cf, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_33d4, 5);  call(0x100a_4d50, 0x1_1977);          /* call 0x100a4d50 */
            ii(0x1009_33d9, 5);  mov(eax, 0x1c);                       /* mov eax, 0x1c */
            ii(0x1009_33de, 5);  call(0x100c_dec2, 0x3_aadf);          /* call 0x100cdec2 */
            ii(0x1009_33e3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_33e5, 2);  if(jz(0x1009_3429, 0x42)) goto l_0x1009_3429;/* jz 0x10093429 */
            ii(0x1009_33e7, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1009_33ec, 5);  call(Definitions.sys_new, 0xd_2a0f);  /* call 0x10165e00 */
            ii(0x1009_33f1, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x1009_33f4, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1009_33f7, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x1009_33fa, 4);  cmp(memd[ss, ebp - 108], 0);          /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x1009_33fe, 2);  if(jz(0x1009_3416, 0x16)) goto l_0x1009_3416;/* jz 0x10093416 */
            ii(0x1009_3400, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3403, 3);  mov(eax, memd[ss, ebp - 104]);        /* mov eax, [ebp-0x68] */
            ii(0x1009_3406, 5);  call(Definitions.my_ctor_c7, 0x6932); /* call 0x10099d3d */
            ii(0x1009_340b, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x1009_340e, 3);  mov(eax, memd[ss, ebp - 112]);        /* mov eax, [ebp-0x70] */
            ii(0x1009_3411, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x1009_3414, 2);  jmp(0x1009_341c, 6); goto l_0x1009_341c;/* jmp 0x1009341c */
        l_0x1009_3416:
            ii(0x1009_3416, 3);  mov(eax, memd[ss, ebp - 108]);        /* mov eax, [ebp-0x6c] */
            ii(0x1009_3419, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
        l_0x1009_341c:
            ii(0x1009_341c, 3);  mov(edx, memd[ss, ebp - 100]);        /* mov edx, [ebp-0x64] */
            ii(0x1009_341f, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3424, 5);  call(0x100a_4d50, 0x1_1927);          /* call 0x100a4d50 */
        l_0x1009_3429:
            ii(0x1009_3429, 5);  mov(eax, 0x17);                       /* mov eax, 0x17 */
            ii(0x1009_342e, 5);  call(Definitions.sys_new, 0xd_29cd);  /* call 0x10165e00 */
            ii(0x1009_3433, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_3436, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_3439, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_343c, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1009_3440, 2);  if(jz(0x1009_3458, 0x16)) goto l_0x1009_3458;/* jz 0x10093458 */
            ii(0x1009_3442, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3445, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_3448, 5);  call(Definitions.my_ctor_c8, 0x6a94); /* call 0x10099ee1 */
            ii(0x1009_344d, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_3450, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_3453, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x1009_3456, 2);  jmp(0x1009_345e, 6); goto l_0x1009_345e;/* jmp 0x1009345e */
        l_0x1009_3458:
            ii(0x1009_3458, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_345b, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
        l_0x1009_345e:
            ii(0x1009_345e, 3);  mov(edx, memd[ss, ebp - 116]);        /* mov edx, [ebp-0x74] */
            ii(0x1009_3461, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3466, 5);  call(0x100a_4d50, 0x1_18e5);          /* call 0x100a4d50 */
            ii(0x1009_346b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_346d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_346e, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_346f, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_3470, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_3471, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_3472, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_3473, 1);  ret();                                /* ret */
        }
    }
}
