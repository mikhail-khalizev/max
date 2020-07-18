using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_4e00-57921bf")]
        public void Method_100a_4e00()
        {
            ii(0x100a_4e00, 5);  push(0x38);                           /* push 0x38 */
            ii(0x100a_4e05, 5);  call(Definitions.sys_check_available_stack_size, 0xc_0f48);/* call 0x10165d52 */
            ii(0x100a_4e0a, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_4e0b, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_4e0c, 1);  push(edx);                            /* push edx */
            ii(0x100a_4e0d, 1);  push(esi);                            /* push esi */
            ii(0x100a_4e0e, 1);  push(edi);                            /* push edi */
            ii(0x100a_4e0f, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_4e10, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_4e12, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x100a_4e18, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_4e1b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4e1e, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_4e21, 5);  call(0x1007_6b90, -0x2_e296);         /* call 0x10076b90 */
            ii(0x100a_4e26, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_4e29, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4e2c, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_4e2f, 5);  call(0x1007_6b90, -0x2_e2a4);         /* call 0x10076b90 */
            ii(0x100a_4e34, 1);  cwde();                               /* cwde */
            ii(0x100a_4e35, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100a_4e37, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_4e39, 2);  if(jnz(0x100a_4e44, 9)) goto l_0x100a_4e44;/* jnz 0x100a4e44 */
            ii(0x100a_4e3b, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_4e3f, 5);  jmp(0x100a_4fa9, 0x165); goto l_0x100a_4fa9;/* jmp 0x100a4fa9 */
        l_0x100a_4e44:
            ii(0x100a_4e44, 5);  call(0x1014_82f4, 0xa_34ab);          /* call 0x101482f4 */
            ii(0x100a_4e49, 6);  sub(eax, memd[ds, 0x101c_3974]);      /* sub eax, [0x101c3974] */
            ii(0x100a_4e4f, 6);  cmp(eax, memd[ds, 0x101b_dd84]);      /* cmp eax, [0x101bdd84] */
            ii(0x100a_4e55, 2);  if(jb(0x100a_4e60, 9)) goto l_0x100a_4e60;/* jb 0x100a4e60 */
            ii(0x100a_4e57, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_4e5b, 5);  jmp(0x100a_4fa9, 0x149); goto l_0x100a_4fa9;/* jmp 0x100a4fa9 */
        l_0x100a_4e60:
            ii(0x100a_4e60, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_4e67, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_4e6b, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4e6e, 5);  call(0x100a_ae9c, 0x6029);            /* call 0x100aae9c */
            ii(0x100a_4e73, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100a_4e76, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
        l_0x100a_4e7a:
            ii(0x100a_4e7a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4e7d, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_4e80, 5);  call(0x1007_6b90, -0x2_e2f5);         /* call 0x10076b90 */
            ii(0x100a_4e85, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x100a_4e88, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4e8b, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_4e8e, 5);  call(0x1007_6b90, -0x2_e303);         /* call 0x10076b90 */
            ii(0x100a_4e93, 1);  cwde();                               /* cwde */
            ii(0x100a_4e94, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100a_4e96, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_4e98, 6);  if(jle(0x100a_4f8f, 0xf1)) goto l_0x100a_4f8f;/* jle 0x100a4f8f */
            ii(0x100a_4e9e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4ea1, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_4ea4, 5);  call(0x1007_6b90, -0x2_e319);         /* call 0x10076b90 */
            ii(0x100a_4ea9, 1);  cwde();                               /* cwde */
            ii(0x100a_4eaa, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_4eac, 2);  if(jnz(0x100a_4eb7, 9)) goto l_0x100a_4eb7;/* jnz 0x100a4eb7 */
            ii(0x100a_4eae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4eb1, 6);  mov(memw[ds, eax + 50], 0);           /* mov word [eax+0x32], 0x0 */
        l_0x100a_4eb7:
            ii(0x100a_4eb7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4eba, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x100a_4ebd, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_4ec0, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x100a_4ec3, 2);  if(jge(0x100a_4ed5, 0x10)) goto l_0x100a_4ed5;/* jge 0x100a4ed5 */
            ii(0x100a_4ec5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4ec8, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_4ecb, 5);  call(0x1007_6b90, -0x2_e340);         /* call 0x10076b90 */
            ii(0x100a_4ed0, 1);  cwde();                               /* cwde */
            ii(0x100a_4ed1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_4ed3, 2);  if(jnz(0x100a_4f0e, 0x39)) goto l_0x100a_4f0e;/* jnz 0x100a4f0e */
        l_0x100a_4ed5:
            ii(0x100a_4ed5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_4ed7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4eda, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_4edd, 5);  call(0x100a_ac80, 0x5d9e);            /* call 0x100aac80 */
            ii(0x100a_4ee2, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x100a_4ee5, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_4ee7, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_4ee9, 5);  call(0x100a_ae20, 0x5f32);            /* call 0x100aae20 */
            ii(0x100a_4eee, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4ef1, 5);  call(0x100a_adf0, 0x5efa);            /* call 0x100aadf0 */
            ii(0x100a_4ef6, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_4ef8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4efb, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_4efe, 5);  call(0x100a_acb8, 0x5db5);            /* call 0x100aacb8 */
            ii(0x100a_4f03, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4f06, 6);  mov(memw[ds, eax + 50], 0);           /* mov word [eax+0x32], 0x0 */
            ii(0x100a_4f0c, 2);  jmp(0x100a_4f43, 0x35); goto l_0x100a_4f43;/* jmp 0x100a4f43 */
        l_0x100a_4f0e:
            ii(0x100a_4f0e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_4f10, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4f13, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_4f16, 5);  call(0x100a_ac80, 0x5d65);            /* call 0x100aac80 */
            ii(0x100a_4f1b, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x100a_4f1e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_4f20, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_4f22, 5);  call(0x100a_ae20, 0x5ef9);            /* call 0x100aae20 */
            ii(0x100a_4f27, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4f2a, 5);  call(0x100a_adf0, 0x5ec1);            /* call 0x100aadf0 */
            ii(0x100a_4f2f, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_4f31, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4f34, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_4f37, 5);  call(0x100a_acb8, 0x5d7c);            /* call 0x100aacb8 */
            ii(0x100a_4f3c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_4f3f, 4);  inc(memw[ds, eax + 50]);              /* inc word [eax+0x32] */
        l_0x100a_4f43:
            ii(0x100a_4f43, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_4f46, 3);  inc(memd[ss, ebp - 16]);              /* inc dword [ebp-0x10] */
            ii(0x100a_4f49, 7);  inc(memw[ds, 0x101c_31b8]);           /* inc word [0x101c31b8] */
            ii(0x100a_4f50, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4f53, 5);  call(0x100a_ad94, 0x5e3c);            /* call 0x100aad94 */
            ii(0x100a_4f58, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_4f5b, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_4f5e, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_4f61, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_4f64, 3);  call_abs(memd[ds, edx + 4]);          /* call dword [edx+0x4] */
            ii(0x100a_4f67, 5);  call(0x1014_82f4, 0xa_3388);          /* call 0x101482f4 */
            ii(0x100a_4f6c, 6);  sub(eax, memd[ds, 0x101c_3974]);      /* sub eax, [0x101c3974] */
            ii(0x100a_4f72, 6);  cmp(eax, memd[ds, 0x101b_dd84]);      /* cmp eax, [0x101bdd84] */
            ii(0x100a_4f78, 2);  if(jb(0x100a_4f8a, 0x10)) goto l_0x100a_4f8a;/* jb 0x100a4f8a */
            ii(0x100a_4f7a, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_4f7e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_4f80, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4f83, 5);  call(0x100a_a0f8, 0x5170);            /* call 0x100aa0f8 */
            ii(0x100a_4f88, 2);  jmp(0x100a_4fa9, 0x1f); goto l_0x100a_4fa9;/* jmp 0x100a4fa9 */
        l_0x100a_4f8a:
            ii(0x100a_4f8a, 5);  jmp(0x100a_4e7a, -0x115); goto l_0x100a_4e7a;/* jmp 0x100a4e7a */
        l_0x100a_4f8f:
            ii(0x100a_4f8f, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_4f93, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_4f95, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x100a_4f98, 5);  call(0x100a_a0f8, 0x515b);            /* call 0x100aa0f8 */
            ii(0x100a_4f9d, 2);  jmp(0x100a_4fa9, 0xa); goto l_0x100a_4fa9;/* jmp 0x100a4fa9 */
        //  ii(0x100a_4f9f, 10);  Недостижимый код.
        l_0x100a_4fa9:
            ii(0x100a_4fa9, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x100a_4fac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_4fae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_4faf, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_4fb0, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_4fb1, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_4fb2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_4fb3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_4fb4, 1);  ret();                                /* ret */
        }
    }
}
