using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_3f62-31507ca2")]
        public void Method_100f_3f62()
        {
            ii(0x100f_3f62, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100f_3f67, 5);  call(Definitions.sys_check_available_stack_size, 0x7_1de6);/* call 0x10165d52 */
            ii(0x100f_3f6c, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_3f6d, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_3f6e, 1);  push(edx);                            /* push edx */
            ii(0x100f_3f6f, 1);  push(esi);                            /* push esi */
            ii(0x100f_3f70, 1);  push(edi);                            /* push edi */
            ii(0x100f_3f71, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_3f72, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_3f74, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100f_3f7a, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x100f_3f7d:
            ii(0x100f_3f7d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_3f80, 4);  cmp(memb[ds, eax + 62], 6);           /* cmp byte [eax+0x3e], 0x6 */
            ii(0x100f_3f84, 2);  if(jnz(0x100f_3f8f, 9)) goto l_0x100f_3f8f;/* jnz 0x100f3f8f */
            ii(0x100f_3f86, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_3f88, 5);  call(0x1010_0efe, 0xcf71);            /* call 0x10100efe */
            ii(0x100f_3f8d, 2);  jmp(0x100f_3f7d, -0x12); goto l_0x100f_3f7d;/* jmp 0x100f3f7d */
        l_0x100f_3f8f:
            ii(0x100f_3f8f, 5);  call(0x1011_606c, 0x2_20d8);          /* call 0x1011606c */
            ii(0x100f_3f94, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_3f97, 4);  cmp(memb[ds, eax + 62], 0x19);        /* cmp byte [eax+0x3e], 0x19 */
            ii(0x100f_3f9b, 6);  if(jnz(0x100f_403b, 0x9a)) goto l_0x100f_403b;/* jnz 0x100f403b */
            ii(0x100f_3fa1, 5);  mov(ecx, 0xffff_ffff);                /* mov ecx, 0xffffffff */
            ii(0x100f_3fa6, 5);  mov(ebx, 0x3e1);                      /* mov ebx, 0x3e1 */
            ii(0x100f_3fab, 5);  mov(edx, 0x3de);                      /* mov edx, 0x3de */
            ii(0x100f_3fb0, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_3fb5, 5);  call(0x1013_daea, 0x4_9b30);          /* call 0x1013daea */
            ii(0x100f_3fba, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_3fbc, 5);  mov(eax, 0x101c_37c0);                /* mov eax, 0x101c37c0 */
            ii(0x100f_3fc1, 5);  call(0x1013_ad71, 0x4_6dab);          /* call 0x1013ad71 */
            ii(0x100f_3fc6, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_3fc8, 2);  if(jz(0x100f_3fd3, 9)) goto l_0x100f_3fd3;/* jz 0x100f3fd3 */
            ii(0x100f_3fca, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x100f_3fd1, 2);  jmp(0x100f_3fec, 0x19); goto l_0x100f_3fec;/* jmp 0x100f3fec */
        l_0x100f_3fd3:
            ii(0x100f_3fd3, 5);  mov(ecx, 0x786);                      /* mov ecx, 0x786 */
            ii(0x100f_3fd8, 5);  mov(ebx, StringDefinitions.GamemgrCpp);/* mov ebx, 0x101a2511 */
            ii(0x100f_3fdd, 5);  mov(edx, StringDefinitions.TempTapeNotEqual0);/* mov edx, 0x101a251d */
            ii(0x100f_3fe2, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_3fe4, 5);  call(Definitions.sys_assert, 0x7_1da9);/* call 0x10165d92 */
            ii(0x100f_3fe9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100f_3fec:
            ii(0x100f_3fec, 5);  mov(eax, 0x101c_37c0);                /* mov eax, 0x101c37c0 */
            ii(0x100f_3ff1, 5);  call(0x1007_6600, -0x7_d9f6);         /* call 0x10076600 */
            ii(0x100f_3ff6, 5);  call(0x1015_f2cc, 0x6_b2d1);          /* call 0x1015f2cc */
            ii(0x100f_3ffb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_3ffd, 5);  mov(eax, 0x101c_37c0);                /* mov eax, 0x101c37c0 */
            ii(0x100f_4002, 5);  call(0x1007_6630, -0x7_d9d7);         /* call 0x10076630 */
            ii(0x100f_4007, 3);  lea(edx, memd[ss, ebp - 12]);         /* lea edx, [ebp-0xc] */
            ii(0x100f_400a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_400d, 5);  call(0x1015_0a5f, 0x5_ca4d);          /* call 0x10150a5f */
            ii(0x100f_4012, 5);  call(0x1009_caf8, -0x5_751f);         /* call 0x1009caf8 */
            ii(0x100f_4017, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_4019, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100f_401c, 5);  call(0x1008_8b04, -0x6_b51d);         /* call 0x10088b04 */
            ii(0x100f_4021, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4024, 3);  mov(dl, memb[ds, eax + 63]);          /* mov dl, [eax+0x3f] */
            ii(0x100f_4027, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_402a, 3);  mov(memb[ds, eax + 61], dl);          /* mov [eax+0x3d], dl */
            ii(0x100f_402d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4030, 3);  mov(dl, memb[ds, eax + 64]);          /* mov dl, [eax+0x40] */
            ii(0x100f_4033, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4036, 3);  mov(memb[ds, eax + 62], dl);          /* mov [eax+0x3e], dl */
            ii(0x100f_4039, 2);  jmp(0x100f_4095, 0x5a); goto l_0x100f_4095;/* jmp 0x100f4095 */
        l_0x100f_403b:
            ii(0x100f_403b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_403e, 4);  mov(dx, memw[ds, eax + 26]);          /* mov dx, [eax+0x1a] */
            ii(0x100f_4042, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4045, 4);  mov(memw[ds, eax + 65], dx);          /* mov [eax+0x41], dx */
            ii(0x100f_4049, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_404c, 4);  mov(dx, memw[ds, eax + 28]);          /* mov dx, [eax+0x1c] */
            ii(0x100f_4050, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4053, 4);  mov(memw[ds, eax + 67], dx);          /* mov [eax+0x43], dx */
            ii(0x100f_4057, 5);  mov(ebx, 0xd);                        /* mov ebx, 0xd */
            ii(0x100f_405c, 5);  mov(edx, 4);                          /* mov edx, 0x4 */
            ii(0x100f_4061, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4064, 5);  call(0x1016_3053, 0x6_efea);          /* call 0x10163053 */
            ii(0x100f_4069, 5);  mov(edx, 0x101c_37bc);                /* mov edx, 0x101c37bc */
            ii(0x100f_406e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4071, 5);  call(0x1007_6d98, -0x7_d2de);         /* call 0x10076d98 */
            ii(0x100f_4076, 2);  test(al, al);                         /* test al, al */
            ii(0x100f_4078, 2);  if(jz(0x100f_4095, 0x1b)) goto l_0x100f_4095;/* jz 0x100f4095 */
            ii(0x100f_407a, 5);  call(0x1010_2bf8, 0xeb79);            /* call 0x10102bf8 */
            ii(0x100f_407f, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x100f_4081, 2);  mov(cl, al);                          /* mov cl, al */
            ii(0x100f_4083, 5);  mov(ebx, 0x10);                       /* mov ebx, 0x10 */
            ii(0x100f_4088, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100f_408b, 5);  mov(eax, 0x101c_7278);                /* mov eax, 0x101c7278 */
            ii(0x100f_4090, 5);  call(0x1013_d5c0, 0x4_952b);          /* call 0x1013d5c0 */
        l_0x100f_4095:
            ii(0x100f_4095, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_4098, 5);  call(0x100f_f637, 0xb59a);            /* call 0x100ff637 */
            ii(0x100f_409d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_409f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_40a0, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_40a1, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_40a2, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_40a3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_40a4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_40a5, 1);  ret();                                /* ret */
        }
    }
}
