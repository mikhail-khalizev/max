using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_4d4d-92797a06")]
        public void Method_1010_4d4d()
        {
            ii(0x1010_4d4d, 5);  push(0x4c);                           /* push 0x4c */
            ii(0x1010_4d52, 5);  call(Definitions.sys_check_available_stack_size, 0x6_0ffb);/* call 0x10165d52 */
            ii(0x1010_4d57, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_4d58, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_4d59, 1);  push(esi);                            /* push esi */
            ii(0x1010_4d5a, 1);  push(edi);                            /* push edi */
            ii(0x1010_4d5b, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_4d5c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_4d5e, 6);  sub(esp, 0x34);                       /* sub esp, 0x34 */
            ii(0x1010_4d64, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4d67, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1010_4d6a, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x1010_4d71, 2);  if(jz(0x1010_4d8a, 0x17)) goto l_0x1010_4d8a;/* jz 0x10104d8a */
            ii(0x1010_4d73, 5);  mov(edx, 0x101b_6490);                /* mov edx, 0x101b6490 */
            ii(0x1010_4d78, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4d7b, 5);  call(Definitions.sys_call_dtor_arr, 0x6_1238);/* call 0x10165fb8 */
            ii(0x1010_4d80, 5);  call(Definitions.sys_delete_arr, 0x6_1253);/* call 0x10165fd8 */
            ii(0x1010_4d85, 5);  jmp(0x1010_4f0a, 0x180); goto l_0x1010_4f0a;/* jmp 0x10104f0a */
        l_0x1010_4d8a:
            ii(0x1010_4d8a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4d8d, 7);  mov(memd[ds, eax + 19], 0x101b_64a4); /* mov dword [eax+0x13], 0x101b64a4 */
            ii(0x1010_4d94, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4d97, 4);  cmp(memd[ds, eax + 51], 0);           /* cmp dword [eax+0x33], 0x0 */
            ii(0x1010_4d9b, 2);  if(jz(0x1010_4dc7, 0x2a)) goto l_0x1010_4dc7;/* jz 0x10104dc7 */
            ii(0x1010_4d9d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4da0, 3);  mov(eax, memd[ds, eax + 51]);         /* mov eax, [eax+0x33] */
            ii(0x1010_4da3, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1010_4da6, 4);  cmp(memd[ss, ebp - 20], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1010_4daa, 2);  if(jz(0x1010_4dc0, 0x14)) goto l_0x1010_4dc0;/* jz 0x10104dc0 */
            ii(0x1010_4dac, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_4dae, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1010_4db1, 5);  call(Definitions.my_dtor_d2, -0x3_687e);/* call 0x100ce538 */
            ii(0x1010_4db6, 5);  call(Definitions.sys_delete, 0x6_11a9);/* call 0x10165f64 */
            ii(0x1010_4dbb, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_4dbe, 2);  jmp(0x1010_4dc7, 7); goto l_0x1010_4dc7;/* jmp 0x10104dc7 */
        l_0x1010_4dc0:
            ii(0x1010_4dc0, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_4dc7:
            ii(0x1010_4dc7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4dca, 4);  cmp(memd[ds, eax + 55], 0);           /* cmp dword [eax+0x37], 0x0 */
            ii(0x1010_4dce, 2);  if(jz(0x1010_4dfa, 0x2a)) goto l_0x1010_4dfa;/* jz 0x10104dfa */
            ii(0x1010_4dd0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4dd3, 3);  mov(eax, memd[ds, eax + 55]);         /* mov eax, [eax+0x37] */
            ii(0x1010_4dd6, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_4dd9, 4);  cmp(memd[ss, ebp - 28], 0);           /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1010_4ddd, 2);  if(jz(0x1010_4df3, 0x14)) goto l_0x1010_4df3;/* jz 0x10104df3 */
            ii(0x1010_4ddf, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_4de1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_4de4, 5);  call(Definitions.my_dtor_d2, -0x3_68b1);/* call 0x100ce538 */
            ii(0x1010_4de9, 5);  call(Definitions.sys_delete, 0x6_1176);/* call 0x10165f64 */
            ii(0x1010_4dee, 3);  mov(memd[ss, ebp - 24], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_4df1, 2);  jmp(0x1010_4dfa, 7); goto l_0x1010_4dfa;/* jmp 0x10104dfa */
        l_0x1010_4df3:
            ii(0x1010_4df3, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1010_4dfa:
            ii(0x1010_4dfa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4dfd, 4);  cmp(memd[ds, eax + 59], 0);           /* cmp dword [eax+0x3b], 0x0 */
            ii(0x1010_4e01, 2);  if(jz(0x1010_4e2d, 0x2a)) goto l_0x1010_4e2d;/* jz 0x10104e2d */
            ii(0x1010_4e03, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e06, 3);  mov(eax, memd[ds, eax + 59]);         /* mov eax, [eax+0x3b] */
            ii(0x1010_4e09, 3);  mov(memd[ss, ebp - 36], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_4e0c, 4);  cmp(memd[ss, ebp - 36], 0);           /* cmp dword [ebp-0x24], 0x0 */
            ii(0x1010_4e10, 2);  if(jz(0x1010_4e26, 0x14)) goto l_0x1010_4e26;/* jz 0x10104e26 */
            ii(0x1010_4e12, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_4e14, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_4e17, 5);  call(Definitions.my_dtor_d2, -0x3_68e4);/* call 0x100ce538 */
            ii(0x1010_4e1c, 5);  call(Definitions.sys_delete, 0x6_1143);/* call 0x10165f64 */
            ii(0x1010_4e21, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_4e24, 2);  jmp(0x1010_4e2d, 7); goto l_0x1010_4e2d;/* jmp 0x10104e2d */
        l_0x1010_4e26:
            ii(0x1010_4e26, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
        l_0x1010_4e2d:
            ii(0x1010_4e2d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e30, 4);  cmp(memd[ds, eax + 63], 0);           /* cmp dword [eax+0x3f], 0x0 */
            ii(0x1010_4e34, 2);  if(jz(0x1010_4e60, 0x2a)) goto l_0x1010_4e60;/* jz 0x10104e60 */
            ii(0x1010_4e36, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e39, 3);  mov(eax, memd[ds, eax + 63]);         /* mov eax, [eax+0x3f] */
            ii(0x1010_4e3c, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1010_4e3f, 4);  cmp(memd[ss, ebp - 44], 0);           /* cmp dword [ebp-0x2c], 0x0 */
            ii(0x1010_4e43, 2);  if(jz(0x1010_4e59, 0x14)) goto l_0x1010_4e59;/* jz 0x10104e59 */
            ii(0x1010_4e45, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_4e47, 3);  mov(eax, memd[ss, ebp - 44]);         /* mov eax, [ebp-0x2c] */
            ii(0x1010_4e4a, 5);  call(Definitions.my_dtor_d2, -0x3_6917);/* call 0x100ce538 */
            ii(0x1010_4e4f, 5);  call(Definitions.sys_delete, 0x6_1110);/* call 0x10165f64 */
            ii(0x1010_4e54, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x1010_4e57, 2);  jmp(0x1010_4e60, 7); goto l_0x1010_4e60;/* jmp 0x10104e60 */
        l_0x1010_4e59:
            ii(0x1010_4e59, 7);  mov(memd[ss, ebp - 40], 0);           /* mov dword [ebp-0x28], 0x0 */
        l_0x1010_4e60:
            ii(0x1010_4e60, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e63, 7);  cmp(memd[ds, eax + 1122], 0);         /* cmp dword [eax+0x462], 0x0 */
            ii(0x1010_4e6a, 2);  if(jz(0x1010_4e99, 0x2d)) goto l_0x1010_4e99;/* jz 0x10104e99 */
            ii(0x1010_4e6c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e6f, 6);  mov(eax, memd[ds, eax + 1122]);       /* mov eax, [eax+0x462] */
            ii(0x1010_4e75, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
            ii(0x1010_4e78, 4);  cmp(memd[ss, ebp - 52], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x1010_4e7c, 2);  if(jz(0x1010_4e92, 0x14)) goto l_0x1010_4e92;/* jz 0x10104e92 */
            ii(0x1010_4e7e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_4e80, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x1010_4e83, 5);  call(Definitions.my_dtor_d3, -0x2_d155);/* call 0x100d7d33 */
            ii(0x1010_4e88, 5);  call(Definitions.sys_delete, 0x6_10d7);/* call 0x10165f64 */
            ii(0x1010_4e8d, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x1010_4e90, 2);  jmp(0x1010_4e99, 7); goto l_0x1010_4e99;/* jmp 0x10104e99 */
        l_0x1010_4e92:
            ii(0x1010_4e92, 7);  mov(memd[ss, ebp - 48], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x1010_4e99:
            ii(0x1010_4e99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4e9c, 7);  cmp(memd[ds, eax + 1132], 0);         /* cmp dword [eax+0x46c], 0x0 */
            ii(0x1010_4ea3, 2);  if(jz(0x1010_4ebd, 0x18)) goto l_0x1010_4ebd;/* jz 0x10104ebd */
            ii(0x1010_4ea5, 5);  mov(edx, 0x101b_5c10);                /* mov edx, 0x101b5c10 */
            ii(0x1010_4eaa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4ead, 6);  mov(eax, memd[ds, eax + 1132]);       /* mov eax, [eax+0x46c] */
            ii(0x1010_4eb3, 5);  call(Definitions.sys_call_dtor_arr, 0x6_1100);/* call 0x10165fb8 */
            ii(0x1010_4eb8, 5);  call(Definitions.sys_delete_arr, 0x6_111b);/* call 0x10165fd8 */
        l_0x1010_4ebd:
            ii(0x1010_4ebd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4ec0, 4);  mov(dx, memw[ds, eax + 69]);          /* mov dx, [eax+0x45] */
            ii(0x1010_4ec4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4ec7, 4);  dec(memw[ds, eax + 69]);              /* dec word [eax+0x45] */
            ii(0x1010_4ecb, 3);  test(dx, dx);                         /* test dx, dx */
            ii(0x1010_4ece, 2);  if(jz(0x1010_4ee9, 0x19)) goto l_0x1010_4ee9;/* jz 0x10104ee9 */
            ii(0x1010_4ed0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4ed3, 3);  mov(eax, memd[ds, eax + 67]);         /* mov eax, [eax+0x43] */
            ii(0x1010_4ed6, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1010_4ed9, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1010_4edc, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1010_4edf, 3);  mov(eax, memd[ds, eax + 71]);         /* mov eax, [eax+0x47] */
            ii(0x1010_4ee2, 5);  call(Definitions.sys_delete, 0x6_107d);/* call 0x10165f64 */
            ii(0x1010_4ee7, 2);  jmp(0x1010_4ebd, -0x2c); goto l_0x1010_4ebd;/* jmp 0x10104ebd */
        l_0x1010_4ee9:
            ii(0x1010_4ee9, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1010_4eee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4ef1, 5);  call(0x100d_6999, -0x2_e55d);         /* call 0x100d6999 */
            ii(0x1010_4ef6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_4ef9, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x1010_4f00, 2);  if(jz(0x1010_4f0a, 8)) goto l_0x1010_4f0a;/* jz 0x10104f0a */
            ii(0x1010_4f02, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4f05, 5);  call(Definitions.sys_delete, 0x6_105a);/* call 0x10165f64 */
        l_0x1010_4f0a:
            ii(0x1010_4f0a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_4f0d, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_4f10, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_4f13, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_4f15, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_4f16, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_4f17, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_4f18, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_4f19, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_4f1a, 1);  ret();                                /* ret */
        }
    }
}
