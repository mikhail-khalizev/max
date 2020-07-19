using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1d82-567bf908")]
        public void Method_1013_1d82()
        {
            ii(0x1013_1d82, 5);  push(0x54);                           /* push 0x54 */
            ii(0x1013_1d87, 5);  call(Definitions.sys_check_available_stack_size, 0x3_3fc6);/* call 0x10165d52 */
            ii(0x1013_1d8c, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1d8d, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1d8e, 1);  push(esi);                            /* push esi */
            ii(0x1013_1d8f, 1);  push(edi);                            /* push edi */
            ii(0x1013_1d90, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1d91, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1d93, 6);  sub(esp, 0x3c);                       /* sub esp, 0x3c */
            ii(0x1013_1d99, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1d9c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1d9f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1da2, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x1013_1da5, 3);  mov(memd[ss, ebp - 56], eax);         /* mov [ebp-0x38], eax */
            ii(0x1013_1da8, 4);  cmp(memd[ss, ebp - 56], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1013_1dac, 2);  if(jz(0x1013_1dc2, 0x14)) goto l_0x1013_1dc2;/* jz 0x10131dc2 */
            ii(0x1013_1dae, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1db0, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x1013_1db3, 5);  call(Definitions.my_dtor_d2, -0x6_3880);/* call 0x100ce538 */
            ii(0x1013_1db8, 5);  call(Definitions.sys_delete, 0x3_41a7);/* call 0x10165f64 */
            ii(0x1013_1dbd, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1013_1dc0, 2);  jmp(0x1013_1dc9, 7); goto l_0x1013_1dc9;/* jmp 0x10131dc9 */
        l_0x1013_1dc2:
            ii(0x1013_1dc2, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1013_1dc9:
            ii(0x1013_1dc9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1dcc, 3);  mov(eax, memd[ds, eax + 11]);         /* mov eax, [eax+0xb] */
            ii(0x1013_1dcf, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1013_1dd2, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1013_1dd6, 2);  if(jz(0x1013_1dec, 0x14)) goto l_0x1013_1dec;/* jz 0x10131dec */
            ii(0x1013_1dd8, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1dda, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1013_1ddd, 5);  call(Definitions.my_dtor_d2, -0x6_38aa);/* call 0x100ce538 */
            ii(0x1013_1de2, 5);  call(Definitions.sys_delete, 0x3_417d);/* call 0x10165f64 */
            ii(0x1013_1de7, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1013_1dea, 2);  jmp(0x1013_1df3, 7); goto l_0x1013_1df3;/* jmp 0x10131df3 */
        l_0x1013_1dec:
            ii(0x1013_1dec, 7);  mov(memd[ss, ebp - 28], 0);           /* mov dword [ebp-0x1c], 0x0 */
        l_0x1013_1df3:
            ii(0x1013_1df3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1df6, 3);  mov(eax, memd[ds, eax + 15]);         /* mov eax, [eax+0xf] */
            ii(0x1013_1df9, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1013_1dfc, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1013_1e00, 2);  if(jz(0x1013_1e16, 0x14)) goto l_0x1013_1e16;/* jz 0x10131e16 */
            ii(0x1013_1e02, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1e04, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x1013_1e07, 5);  call(Definitions.my_dtor_d2, -0x6_38d4);/* call 0x100ce538 */
            ii(0x1013_1e0c, 5);  call(Definitions.sys_delete, 0x3_4153);/* call 0x10165f64 */
            ii(0x1013_1e11, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_1e14, 2);  jmp(0x1013_1e1d, 7); goto l_0x1013_1e1d;/* jmp 0x10131e1d */
        l_0x1013_1e16:
            ii(0x1013_1e16, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1013_1e1d:
            ii(0x1013_1e1d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1e20, 3);  mov(eax, memd[ds, eax + 19]);         /* mov eax, [eax+0x13] */
            ii(0x1013_1e23, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1013_1e26, 4);  cmp(memd[ss, ebp - 44], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1013_1e2a, 2);  if(jz(0x1013_1e40, 0x14)) goto l_0x1013_1e40;/* jz 0x10131e40 */
            ii(0x1013_1e2c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1e2e, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1013_1e31, 5);  call(Definitions.my_dtor_d3, -0x5_a103);/* call 0x100d7d33 */
            ii(0x1013_1e36, 5);  call(Definitions.sys_delete, 0x3_4129);/* call 0x10165f64 */
            ii(0x1013_1e3b, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1013_1e3e, 2);  jmp(0x1013_1e47, 7); goto l_0x1013_1e47;/* jmp 0x10131e47 */
        l_0x1013_1e40:
            ii(0x1013_1e40, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
        l_0x1013_1e47:
            ii(0x1013_1e47, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1e4a, 3);  mov(eax, memd[ds, eax + 23]);         /* mov eax, [eax+0x17] */
            ii(0x1013_1e4d, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1013_1e50, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1013_1e54, 2);  if(jz(0x1013_1e6a, 0x14)) goto l_0x1013_1e6a;/* jz 0x10131e6a */
            ii(0x1013_1e56, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1e58, 3);  mov(eax, memd[ss, ebp - 40]);         /* mov eax, [ebp-0x28] */
            ii(0x1013_1e5b, 5);  call(Definitions.my_dtor_d3, -0x5_a12d);/* call 0x100d7d33 */
            ii(0x1013_1e60, 5);  call(Definitions.sys_delete, 0x3_40ff);/* call 0x10165f64 */
            ii(0x1013_1e65, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_1e68, 2);  jmp(0x1013_1e71, 7); goto l_0x1013_1e71;/* jmp 0x10131e71 */
        l_0x1013_1e6a:
            ii(0x1013_1e6a, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1013_1e71:
            ii(0x1013_1e71, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1e74, 3);  mov(eax, memd[ds, eax + 27]);         /* mov eax, [eax+0x1b] */
            ii(0x1013_1e77, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1013_1e7a, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1013_1e7e, 2);  if(jz(0x1013_1e94, 0x14)) goto l_0x1013_1e94;/* jz 0x10131e94 */
            ii(0x1013_1e80, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_1e82, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1013_1e85, 5);  call(Definitions.my_dtor_d3, -0x5_a157);/* call 0x100d7d33 */
            ii(0x1013_1e8a, 5);  call(Definitions.sys_delete, 0x3_40d5);/* call 0x10165f64 */
            ii(0x1013_1e8f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_1e92, 2);  jmp(0x1013_1e9b, 7); goto l_0x1013_1e9b;/* jmp 0x10131e9b */
        l_0x1013_1e94:
            ii(0x1013_1e94, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
        l_0x1013_1e9b:
            ii(0x1013_1e9b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1e9e, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x1013_1ea1, 3);  mov(eax, memd[ss, ebp - 60]);         /* mov eax, [ebp-0x3c] */
            ii(0x1013_1ea4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1ea6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1ea7, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1ea8, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1ea9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1eaa, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1eab, 1);  ret();                                /* ret */
        }
    }
}
