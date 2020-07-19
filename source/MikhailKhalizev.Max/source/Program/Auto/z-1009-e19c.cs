using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e19c-331ec312")]
        public void Method_1009_e19c()
        {
            ii(0x1009_e19c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_e1a1, 5);  call(Definitions.sys_check_available_stack_size, 0xc_7bac);/* call 0x10165d52 */
            ii(0x1009_e1a6, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_e1a7, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e1a8, 1);  push(edx);                            /* push edx */
            ii(0x1009_e1a9, 1);  push(esi);                            /* push esi */
            ii(0x1009_e1aa, 1);  push(edi);                            /* push edi */
            ii(0x1009_e1ab, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e1ac, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e1ae, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_e1b4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_e1b7, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e1b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e1bc, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e1bf, 5);  call(0x1013_ad11, 0x9_cb4d);          /* call 0x1013ad11 */
            ii(0x1009_e1c4, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e1c6, 6);  if(jnz(0x1009_e313, 0x147)) goto l_0x1009_e313;/* jnz 0x1009e313 */
            ii(0x1009_e1cc, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e1cf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e1d2, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e1d5, 5);  call(0x1007_6574, -0x2_7c66);         /* call 0x10076574 */
            ii(0x1009_e1da, 5);  call(0x1015_2a52, 0xb_4873);          /* call 0x10152a52 */
            ii(0x1009_e1df, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e1e1, 2);  if(jz(0x1009_e1fa, 0x17)) goto l_0x1009_e1fa;/* jz 0x1009e1fa */
            ii(0x1009_e1e3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e1e6, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e1e9, 5);  call(0x1007_6574, -0x2_7c7a);         /* call 0x10076574 */
            ii(0x1009_e1ee, 3);  mov(al, memb[ds, eax + 78]);          /* mov al, [eax+0x4e] */
            ii(0x1009_e1f1, 5);  and(eax, 0xff);                       /* and eax, 0xff */
            ii(0x1009_e1f6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_e1f8, 2);  if(jnz(0x1009_e207, 0xd)) goto l_0x1009_e207;/* jnz 0x1009e207 */
        l_0x1009_e1fa:
            ii(0x1009_e1fa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e1fd, 5);  call(0x1009_e31c, 0x11a);             /* call 0x1009e31c */
            ii(0x1009_e202, 5);  jmp(0x1009_e313, 0x10c); goto l_0x1009_e313;/* jmp 0x1009e313 */
        l_0x1009_e207:
            ii(0x1009_e207, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e20a, 4);  cmp(memb[ds, eax + 62], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_e20e, 2);  if(jnz(0x1009_e25d, 0x4d)) goto l_0x1009_e25d;/* jnz 0x1009e25d */
            ii(0x1009_e210, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x1009_e215, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e218, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e21b, 5);  call(0x1007_65d0, -0x2_7c50);         /* call 0x100765d0 */
            ii(0x1009_e220, 3);  mov(ecx, memd[ss, ebp - 4]);          /* mov ecx, [ebp-0x4] */
            ii(0x1009_e223, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1009_e225, 2);  mov(eax, ecx);                        /* mov eax, ecx */
            ii(0x1009_e227, 5);  call(0x100a_3671, 0x5445);            /* call 0x100a3671 */
            ii(0x1009_e22c, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e22e, 2);  if(jz(0x1009_e23d, 0xd)) goto l_0x1009_e23d;/* jz 0x1009e23d */
            ii(0x1009_e230, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e233, 5);  call(0x1009_e31c, 0xe4);              /* call 0x1009e31c */
            ii(0x1009_e238, 5);  jmp(0x1009_e313, 0xd6); goto l_0x1009_e313;/* jmp 0x1009e313 */
        l_0x1009_e23d:
            ii(0x1009_e23d, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x1009_e242, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e245, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e248, 5);  call(0x1007_65d0, -0x2_7c7d);         /* call 0x100765d0 */
            ii(0x1009_e24d, 5);  call(0x100a_32c3, 0x5071);            /* call 0x100a32c3 */
            ii(0x1009_e252, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e254, 2);  if(jz(0x1009_e25d, 7)) goto l_0x1009_e25d;/* jz 0x1009e25d */
            ii(0x1009_e256, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e259, 4);  mov(memb[ds, eax + 62], 1);           /* mov byte [eax+0x3e], 0x1 */
        l_0x1009_e25d:
            ii(0x1009_e25d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e260, 4);  cmp(memb[ds, eax + 62], 0);           /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1009_e264, 2);  if(jz(0x1009_e2a3, 0x3d)) goto l_0x1009_e2a3;/* jz 0x1009e2a3 */
            ii(0x1009_e266, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e269, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e26c, 5);  call(0x1007_6574, -0x2_7cfd);         /* call 0x10076574 */
            ii(0x1009_e271, 4);  mov(dx, memw[ds, eax + 26]);          /* mov dx, [eax+0x1a] */
            ii(0x1009_e275, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e278, 4);  cmp(dx, memw[ds, eax + 23]);          /* cmp dx, [eax+0x17] */
            ii(0x1009_e27c, 2);  if(jnz(0x1009_e296, 0x18)) goto l_0x1009_e296;/* jnz 0x1009e296 */
            ii(0x1009_e27e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e281, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e284, 5);  call(0x1007_6574, -0x2_7d15);         /* call 0x10076574 */
            ii(0x1009_e289, 4);  mov(dx, memw[ds, eax + 28]);          /* mov dx, [eax+0x1c] */
            ii(0x1009_e28d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e290, 4);  cmp(dx, memw[ds, eax + 25]);          /* cmp dx, [eax+0x19] */
            ii(0x1009_e294, 2);  if(jz(0x1009_e2a3, 0xd)) goto l_0x1009_e2a3;/* jz 0x1009e2a3 */
        l_0x1009_e296:
            ii(0x1009_e296, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e299, 5);  call(0x1009_e31c, 0x7e);              /* call 0x1009e31c */
            ii(0x1009_e29e, 5);  jmp(0x1009_e313, 0x70); goto l_0x1009_e313;/* jmp 0x1009e313 */
        l_0x1009_e2a3:
            ii(0x1009_e2a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2a6, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_e2a9, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_e2ac, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_e2af, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_e2b2, 4);  mov(dx, memw[ds, eax + 35]);          /* mov dx, [eax+0x23] */
            ii(0x1009_e2b6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2b9, 4);  cmp(dx, memw[ds, eax + 47]);          /* cmp dx, [eax+0x2f] */
            ii(0x1009_e2bd, 2);  if(jnz(0x1009_e2db, 0x1c)) goto l_0x1009_e2db;/* jnz 0x1009e2db */
            ii(0x1009_e2bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2c2, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_e2c5, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_e2c8, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1009_e2cb, 3);  add(eax, memd[ss, ebp - 4]);          /* add eax, [ebp-0x4] */
            ii(0x1009_e2ce, 4);  mov(dx, memw[ds, eax + 37]);          /* mov dx, [eax+0x25] */
            ii(0x1009_e2d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2d5, 4);  cmp(dx, memw[ds, eax + 49]);          /* cmp dx, [eax+0x31] */
            ii(0x1009_e2d9, 2);  if(jz(0x1009_e2fd, 0x22)) goto l_0x1009_e2fd;/* jz 0x1009e2fd */
        l_0x1009_e2db:
            ii(0x1009_e2db, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2de, 4);  mov(dx, memw[ds, eax + 35]);          /* mov dx, [eax+0x23] */
            ii(0x1009_e2e2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2e5, 4);  cmp(dx, memw[ds, eax + 39]);          /* cmp dx, [eax+0x27] */
            ii(0x1009_e2e9, 2);  if(jnz(0x1009_e2fb, 0x10)) goto l_0x1009_e2fb;/* jnz 0x1009e2fb */
            ii(0x1009_e2eb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2ee, 4);  mov(dx, memw[ds, eax + 37]);          /* mov dx, [eax+0x25] */
            ii(0x1009_e2f2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e2f5, 4);  cmp(dx, memw[ds, eax + 41]);          /* cmp dx, [eax+0x29] */
            ii(0x1009_e2f9, 2);  if(jz(0x1009_e2fd, 2)) goto l_0x1009_e2fd;/* jz 0x1009e2fd */
        l_0x1009_e2fb:
            ii(0x1009_e2fb, 2);  jmp(0x1009_e2ff, 2); goto l_0x1009_e2ff;/* jmp 0x1009e2ff */
        l_0x1009_e2fd:
            ii(0x1009_e2fd, 2);  jmp(0x1009_e30b, 0xc); goto l_0x1009_e30b;/* jmp 0x1009e30b */
        l_0x1009_e2ff:
            ii(0x1009_e2ff, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e302, 5);  call(0x1009_d691, -0xc76);            /* call 0x1009d691 */
            ii(0x1009_e307, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e309, 2);  if(jnz(0x1009_e313, 8)) goto l_0x1009_e313;/* jnz 0x1009e313 */
        l_0x1009_e30b:
            ii(0x1009_e30b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e30e, 5);  call(0x1009_d4ae, -0xe65);            /* call 0x1009d4ae */
        l_0x1009_e313:
            ii(0x1009_e313, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e315, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e316, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e317, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e318, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_e319, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e31a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_e31b, 1);  ret();                                /* ret */
        }
    }
}
