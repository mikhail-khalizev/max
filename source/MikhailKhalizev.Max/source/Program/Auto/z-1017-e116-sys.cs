using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_e116-d7981e20")]
        public void /* sys */ Method_1017_e116()
        {
            ii(0x1017_e116, 1);  push(edx);                            /* push edx */
            ii(0x1017_e117, 1);  push(esi);                            /* push esi */
            ii(0x1017_e118, 1);  push(edi);                            /* push edi */
            ii(0x1017_e119, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_e11a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_e11c, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x1017_e122, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1017_e125, 4);  mov(memw[ss, ebp - 48], cx);          /* mov [ebp-0x30], cx */
            ii(0x1017_e129, 3);  mov(memd[ss, ebp - 52], ebx);         /* mov [ebp-0x34], ebx */
            ii(0x1017_e12c, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1017_e133, 7);  mov(memd[ss, ebp - 20], 0x30);        /* mov dword [ebp-0x14], 0x30 */
            ii(0x1017_e13a, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x1017_e141, 7);  mov(memd[ss, ebp - 36], 0);           /* mov dword [ebp-0x24], 0x0 */
            ii(0x1017_e148, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1017_e14c, 2);  if(jnz(0x1017_e161, 0x13)) goto l_0x1017_e161;/* jnz 0x1017e161 */
            ii(0x1017_e14e, 5);  cmp(memw[ss, ebp - 48], 0);           /* cmp word [ebp-0x30], 0x0 */
            ii(0x1017_e153, 2);  if(jnz(0x1017_e161, 0xc)) goto l_0x1017_e161;/* jnz 0x1017e161 */
            ii(0x1017_e155, 7);  mov(memd[ss, ebp - 40], 2);           /* mov dword [ebp-0x28], 0x2 */
            ii(0x1017_e15c, 5);  jmp(0x1017_e387, 0x226); goto l_0x1017_e387;/* jmp 0x1017e387 */
        l_0x1017_e161:
            ii(0x1017_e161, 7);  cmp(memd[ss, ebp - 44], 0xe000);      /* cmp dword [ebp-0x2c], 0xe000 */
            ii(0x1017_e168, 2);  if(jb(0x1017_e173, 9)) goto l_0x1017_e173;/* jb 0x1017e173 */
            ii(0x1017_e16a, 7);  cmp(memd[ss, ebp - 44], 0xe200);      /* cmp dword [ebp-0x2c], 0xe200 */
            ii(0x1017_e171, 2);  if(jbe(0x1017_e17f, 0xc)) goto l_0x1017_e17f;/* jbe 0x1017e17f */
        l_0x1017_e173:
            ii(0x1017_e173, 7);  mov(memd[ss, ebp - 40], 6);           /* mov dword [ebp-0x28], 0x6 */
            ii(0x1017_e17a, 5);  jmp(0x1017_e387, 0x208); goto l_0x1017_e387;/* jmp 0x1017e387 */
        l_0x1017_e17f:
            ii(0x1017_e17f, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1017_e186, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1017_e18d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1017_e18f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_e191, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e196, 5);  call(Definitions.sys_lseek, -0x1004); /* call 0x1017d197 */
            ii(0x1017_e19b, 5);  mov(ebx, 0x2c);                       /* mov ebx, 0x2c */
            ii(0x1017_e1a0, 5);  mov(edx, 0x1020_a10c);                /* mov edx, 0x1020a10c */
            ii(0x1017_e1a5, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e1aa, 5);  call(/* sys */ 0x1017_d1fa, -0xfb5);  /* call 0x1017d1fa */
        l_0x1017_e1af:
            ii(0x1017_e1af, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1017_e1b2, 6);  cmp(eax, memd[ds, 0x1020_a12c]);      /* cmp eax, [0x1020a12c] */
            ii(0x1017_e1b8, 2);  if(ja(0x1017_e1c0, 6)) goto l_0x1017_e1c0;/* ja 0x1017e1c0 */
            ii(0x1017_e1ba, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1017_e1be, 2);  if(jz(0x1017_e1c5, 5)) goto l_0x1017_e1c5;/* jz 0x1017e1c5 */
        l_0x1017_e1c0:
            ii(0x1017_e1c0, 5);  jmp(0x1017_e24f, 0x8a); goto l_0x1017_e24f;/* jmp 0x1017e24f */
        l_0x1017_e1c5:
            ii(0x1017_e1c5, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1017_e1ca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1017_e1cc, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e1d1, 5);  call(Definitions.sys_lseek, -0x103f); /* call 0x1017d197 */
            ii(0x1017_e1d6, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1017_e1d9, 3);  mov(ebx, memd[ss, ebp - 20]);         /* mov ebx, [ebp-0x14] */
            ii(0x1017_e1dc, 5);  mov(edx, 0x1020_a0dc);                /* mov edx, 0x1020a0dc */
            ii(0x1017_e1e1, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e1e6, 5);  call(/* sys */ 0x1017_d1fa, -0xff1);  /* call 0x1017d1fa */
            ii(0x1017_e1eb, 5);  mov(eax, memd[ds, 0x1020_a100]);      /* mov eax, [0x1020a100] */
            ii(0x1017_e1f0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1017_e1f3, 5);  mov(eax, memd[ds, 0x1020_a104]);      /* mov eax, [0x1020a104] */
            ii(0x1017_e1f8, 3);  cmp(eax, memd[ss, ebp - 44]);         /* cmp eax, [ebp-0x2c] */
            ii(0x1017_e1fb, 2);  if(jnz(0x1017_e206, 9)) goto l_0x1017_e206;/* jnz 0x1017e206 */
            ii(0x1017_e1fd, 7);  test(memb[ds, 0x1020_a109], 0x80);    /* test byte [0x1020a109], 0x80 */
            ii(0x1017_e204, 2);  if(jnz(0x1017_e208, 2)) goto l_0x1017_e208;/* jnz 0x1017e208 */
        l_0x1017_e206:
            ii(0x1017_e206, 2);  jmp(0x1017_e235, 0x2d); goto l_0x1017_e235;/* jmp 0x1017e235 */
        l_0x1017_e208:
            ii(0x1017_e208, 7);  mov(memd[ss, ebp - 12], 1);           /* mov dword [ebp-0xc], 0x1 */
            ii(0x1017_e20f, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1017_e212, 1);  push(eax);                            /* push eax */
            ii(0x1017_e213, 3);  mov(esi, memd[ss, ebp - 4]);          /* mov esi, [ebp-0x4] */
            ii(0x1017_e216, 7);  mov(bx, memw[ds, 0x1020_a1ba]);       /* mov bx, [0x1020a1ba] */
            ii(0x1017_e21d, 6);  mov(edx, memd[ds, 0x1020_a1b6]);      /* mov edx, [0x1020a1b6] */
            ii(0x1017_e223, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e228, 2);  mov(ecx, ebx);                        /* mov ecx, ebx */
            ii(0x1017_e22a, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1017_e22c, 2);  mov(edx, esi);                        /* mov edx, esi */
            ii(0x1017_e22e, 5);  call(/* sys */ 0x1017_9414, -0x4e1f); /* call 0x10179414 */
            ii(0x1017_e233, 2);  jmp(0x1017_e247, 0x12); goto l_0x1017_e247;/* jmp 0x1017e247 */
        l_0x1017_e235:
            ii(0x1017_e235, 5);  mov(ebx, 1);                          /* mov ebx, 0x1 */
            ii(0x1017_e23a, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1017_e23d, 5);  mov(eax, memd[ds, 0x1020_a13c]);      /* mov eax, [0x1020a13c] */
            ii(0x1017_e242, 5);  call(Definitions.sys_lseek, -0x10b0); /* call 0x1017d197 */
        l_0x1017_e247:
            ii(0x1017_e247, 3);  inc(memd[ss, ebp - 8]);               /* inc dword [ebp-0x8] */
            ii(0x1017_e24a, 5);  jmp(0x1017_e1af, -0xa0); goto l_0x1017_e1af;/* jmp 0x1017e1af */
        l_0x1017_e24f:
            ii(0x1017_e24f, 4);  cmp(memd[ss, ebp - 12], 1);           /* cmp dword [ebp-0xc], 0x1 */
            ii(0x1017_e253, 6);  if(jnz(0x1017_e380, 0x127)) goto l_0x1017_e380;/* jnz 0x1017e380 */
            ii(0x1017_e259, 2);  mov(eax, ds);                         /* mov eax, ds */
            ii(0x1017_e25b, 5);  mov(edx, 0x1020_a140);                /* mov edx, 0x1020a140 */
            ii(0x1017_e260, 3);  movzx(eax, ax);                       /* movzx eax, ax */
            ii(0x1017_e263, 1);  push(eax);                            /* push eax */
            ii(0x1017_e264, 1);  push(edx);                            /* push edx */
            ii(0x1017_e265, 7);  movzx(eax, memw[ds, 0x1020_a1ba]);    /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e26c, 1);  push(eax);                            /* push eax */
            ii(0x1017_e26d, 6);  push(memd[ds, 0x1020_a1b6]);          /* push dword [0x1020a1b6] */
            ii(0x1017_e273, 7);  movzx(edx, memw[ds, 0x1020_a1c0]);    /* movzx edx, word [0x1020a1c0] */
            ii(0x1017_e27a, 1);  push(edx);                            /* push edx */
            ii(0x1017_e27b, 6);  push(memd[ds, 0x1020_a1bc]);          /* push dword [0x1020a1bc] */
            ii(0x1017_e281, 5);  call(/* sys */ 0x1019_4f75, 0x1_6cef);/* call 0x10194f75 */
            ii(0x1017_e286, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1017_e289, 7);  test(memb[ds, 0x1020_a17d], 1);       /* test byte [0x1020a17d], 0x1 */
            ii(0x1017_e290, 2);  if(jz(0x1017_e2f2, 0x60)) goto l_0x1017_e2f2;/* jz 0x1017e2f2 */
            ii(0x1017_e292, 7);  movzx(eax, memw[ds, 0x1020_a1ba]);    /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e299, 1);  push(eax);                            /* push eax */
            ii(0x1017_e29a, 6);  push(memd[ds, 0x1020_a1b6]);          /* push dword [0x1020a1b6] */
            ii(0x1017_e2a0, 7);  movzx(eax, memw[ds, 0x1020_a1c0]);    /* movzx eax, word [0x1020a1c0] */
            ii(0x1017_e2a7, 1);  push(eax);                            /* push eax */
            ii(0x1017_e2a8, 6);  push(memd[ds, 0x1020_a1bc]);          /* push dword [0x1020a1bc] */
            ii(0x1017_e2ae, 5);  call(/* sys */ 0x1019_51a8, 0x1_6ef5);/* call 0x101951a8 */
            ii(0x1017_e2b3, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1017_e2b6, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1017_e2bd:
            ii(0x1017_e2bd, 3);  push(memd[ss, ebp - 32]);             /* push dword [ebp-0x20] */
            ii(0x1017_e2c0, 5);  call(/* sys */ 0x1019_51e7, 0x1_6f22);/* call 0x101951e7 */
            ii(0x1017_e2c5, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_e2c8, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_e2ca, 2);  if(jz(0x1017_e2f2, 0x26)) goto l_0x1017_e2f2;/* jz 0x1017e2f2 */
            ii(0x1017_e2cc, 3);  push(memd[ss, ebp - 32]);             /* push dword [ebp-0x20] */
            ii(0x1017_e2cf, 5);  call(/* sys */ 0x1019_51e7, 0x1_6f13);/* call 0x101951e7 */
            ii(0x1017_e2d4, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_e2d7, 5);  call(/* sys */ 0x1019_54bf, 0x1_71e3);/* call 0x101954bf */
            ii(0x1017_e2dc, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1017_e2df, 3);  push(memd[ss, ebp - 36]);             /* push dword [ebp-0x24] */
            ii(0x1017_e2e2, 3);  push(memd[ss, ebp - 32]);             /* push dword [ebp-0x20] */
            ii(0x1017_e2e5, 5);  call(/* sys */ 0x1019_5231, 0x1_6f47);/* call 0x10195231 */
            ii(0x1017_e2ea, 3);  add(esp, 8);                          /* add esp, 0x8 */
            ii(0x1017_e2ed, 3);  inc(memd[ss, ebp - 32]);              /* inc dword [ebp-0x20] */
            ii(0x1017_e2f0, 2);  jmp(0x1017_e2bd, -0x35); goto l_0x1017_e2bd;/* jmp 0x1017e2bd */
        l_0x1017_e2f2:
            ii(0x1017_e2f2, 7);  movzx(eax, memw[ds, 0x1020_a1ba]);    /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e2f9, 1);  push(eax);                            /* push eax */
            ii(0x1017_e2fa, 6);  push(memd[ds, 0x1020_a1b6]);          /* push dword [0x1020a1b6] */
            ii(0x1017_e300, 7);  movzx(eax, memw[ds, 0x1020_a1c0]);    /* movzx eax, word [0x1020a1c0] */
            ii(0x1017_e307, 1);  push(eax);                            /* push eax */
            ii(0x1017_e308, 6);  push(memd[ds, 0x1020_a1bc]);          /* push dword [0x1020a1bc] */
            ii(0x1017_e30e, 5);  call(/* sys */ 0x1019_4f0e, 0x1_6bfb);/* call 0x10194f0e */
            ii(0x1017_e313, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1017_e316, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1017_e319, 4);  cmp(memd[ss, ebp - 16], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1017_e31d, 2);  if(jz(0x1017_e377, 0x58)) goto l_0x1017_e377;/* jz 0x1017e377 */
            ii(0x1017_e31f, 4);  movzx(eax, memw[ss, ebp - 48]);       /* movzx eax, word [ebp-0x30] */
            ii(0x1017_e323, 1);  push(eax);                            /* push eax */
            ii(0x1017_e324, 3);  push(memd[ss, ebp - 52]);             /* push dword [ebp-0x34] */
            ii(0x1017_e327, 7);  movzx(eax, memw[ds, 0x1020_a1ba]);    /* movzx eax, word [0x1020a1ba] */
            ii(0x1017_e32e, 1);  push(eax);                            /* push eax */
            ii(0x1017_e32f, 6);  push(memd[ds, 0x1020_a1b6]);          /* push dword [0x1020a1b6] */
            ii(0x1017_e335, 7);  movzx(eax, memw[ds, 0x1020_a1c0]);    /* movzx eax, word [0x1020a1c0] */
            ii(0x1017_e33c, 1);  push(eax);                            /* push eax */
            ii(0x1017_e33d, 6);  push(memd[ds, 0x1020_a1bc]);          /* push dword [0x1020a1bc] */
            ii(0x1017_e343, 5);  call(/* sys */ 0x1019_4f75, 0x1_6c2d);/* call 0x10194f75 */
            ii(0x1017_e348, 3);  add(esp, 0x18);                       /* add esp, 0x18 */
            ii(0x1017_e34b, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1017_e34e, 6);  mov(memw[ds, 0x1020_a1b4], ax);       /* mov [0x1020a1b4], ax */
            ii(0x1017_e354, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1017_e357, 5);  mov(memd[ds, 0x1020_a1b0], eax);      /* mov [0x1020a1b0], eax */
            ii(0x1017_e35c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1017_e35f, 4);  lgs(edx, memd[ss, ebp + 20]);         /* lgs edx, [ebp+0x14] */
            ii(0x1017_e363, 3);  mov(memd[gs, edx], eax);              /* mov [gs:edx], eax */
            ii(0x1017_e366, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1017_e369, 5);  mov(memd[ds, 0x1020_a138], eax);      /* mov [0x1020a138], eax */
            ii(0x1017_e36e, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
            ii(0x1017_e375, 2);  jmp(0x1017_e387, 0x10); goto l_0x1017_e387;/* jmp 0x1017e387 */
        l_0x1017_e377:
            ii(0x1017_e377, 7);  mov(memd[ss, ebp - 40], 8);           /* mov dword [ebp-0x28], 0x8 */
            ii(0x1017_e37e, 2);  jmp(0x1017_e387, 7); goto l_0x1017_e387;/* jmp 0x1017e387 */
        l_0x1017_e380:
            ii(0x1017_e380, 7);  mov(memd[ss, ebp - 40], 7);           /* mov dword [ebp-0x28], 0x7 */
        l_0x1017_e387:
            ii(0x1017_e387, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1017_e38a, 1);  leave();                              /* leave */
            ii(0x1017_e38b, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_e38c, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_e38d, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_e38e, 3);  ret(8);                               /* ret 0x8 */
        }
    }
}
