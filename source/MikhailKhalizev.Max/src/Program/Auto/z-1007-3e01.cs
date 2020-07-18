using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_3e01-e350623d")]
        public void Method_1007_3e01()
        {
            ii(0x1007_3e01, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1007_3e06, 5);  call(Definitions.sys_check_available_stack_size, 0xf_1f47);/* call 0x10165d52 */
            ii(0x1007_3e0b, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_3e0c, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_3e0d, 1);  push(esi);                            /* push esi */
            ii(0x1007_3e0e, 1);  push(edi);                            /* push edi */
            ii(0x1007_3e0f, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_3e10, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_3e12, 6);  sub(esp, 0x1c);                       /* sub esp, 0x1c */
            ii(0x1007_3e18, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_3e1b, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_3e1e, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1007_3e20, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_3e23, 3);  mov(al, memb[ds, edx + 38]);          /* mov al, [edx+0x26] */
            ii(0x1007_3e26, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_3e29, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_3e2c, 5);  call(0x1007_6204, 0x23d3);            /* call 0x10076204 */
            ii(0x1007_3e31, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x1007_3e34, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_3e36, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_3e38, 5);  call(0x1007_6954, 0x2b17);            /* call 0x10076954 */
            ii(0x1007_3e3d, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x1007_3e42, 5);  call(0x1007_6338, 0x24f1);            /* call 0x10076338 */
            ii(0x1007_3e47, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_3e49, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3e4c, 5);  call(0x1007_64b8, 0x2667);            /* call 0x100764b8 */
            ii(0x1007_3e51, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
        l_0x1007_3e58:
            ii(0x1007_3e58, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3e5a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3e5d, 5);  call(0x1013_ad71, 0xc_6f0f);          /* call 0x1013ad71 */
            ii(0x1007_3e62, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_3e64, 6);  if(jz(0x1007_3f01, 0x97)) goto l_0x1007_3f01;/* jz 0x10073f01 */
            ii(0x1007_3e6a, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3e6d, 5);  call(0x1007_63a0, 0x252e);            /* call 0x100763a0 */
            ii(0x1007_3e72, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3e74, 3);  mov(dl, memb[ds, eax + 38]);          /* mov dl, [eax+0x26] */
            ii(0x1007_3e77, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x1007_3e7b, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_3e7d, 2);  if(jnz(0x1007_3e91, 0x12)) goto l_0x1007_3e91;/* jnz 0x10073e91 */
            ii(0x1007_3e7f, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3e82, 5);  call(0x1007_63a0, 0x2519);            /* call 0x100763a0 */
            ii(0x1007_3e87, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1007_3e8b, 4);  cmp(ax, memw[ss, ebp - 4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1007_3e8f, 2);  if(jz(0x1007_3e93, 2)) goto l_0x1007_3e93;/* jz 0x10073e93 */
        l_0x1007_3e91:
            ii(0x1007_3e91, 2);  jmp(0x1007_3eac, 0x19); goto l_0x1007_3eac;/* jmp 0x10073eac */
        l_0x1007_3e93:
            ii(0x1007_3e93, 3);  lea(edx, memd[ss, ebp - 16]);         /* lea edx, [ebp-0x10] */
            ii(0x1007_3e96, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3e99, 5);  call(0x1007_63a0, 0x2502);            /* call 0x100763a0 */
            ii(0x1007_3e9e, 5);  call(0x1007_6204, 0x2361);            /* call 0x10076204 */
            ii(0x1007_3ea3, 5);  call(0x1007_6d98, 0x2ef0);            /* call 0x10076d98 */
            ii(0x1007_3ea8, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_3eaa, 2);  if(jnz(0x1007_3eae, 2)) goto l_0x1007_3eae;/* jnz 0x10073eae */
        l_0x1007_3eac:
            ii(0x1007_3eac, 2);  jmp(0x1007_3ebc, 0xe); goto l_0x1007_3ebc;/* jmp 0x10073ebc */
        l_0x1007_3eae:
            ii(0x1007_3eae, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3eb1, 5);  call(0x1007_63a0, 0x24ea);            /* call 0x100763a0 */
            ii(0x1007_3eb6, 4);  cmp(memb[ds, eax + 61], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1007_3eba, 2);  if(jnz(0x1007_3ebe, 2)) goto l_0x1007_3ebe;/* jnz 0x10073ebe */
        l_0x1007_3ebc:
            ii(0x1007_3ebc, 2);  jmp(0x1007_3ecc, 0xe); goto l_0x1007_3ecc;/* jmp 0x10073ecc */
        l_0x1007_3ebe:
            ii(0x1007_3ebe, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3ec1, 5);  call(0x1007_63a0, 0x24da);            /* call 0x100763a0 */
            ii(0x1007_3ec6, 4);  cmp(memb[ds, eax + 61], 8);           /* cmp byte [eax+0x3d], 0x8 */
            ii(0x1007_3eca, 2);  if(jnz(0x1007_3ece, 2)) goto l_0x1007_3ece;/* jnz 0x10073ece */
        l_0x1007_3ecc:
            ii(0x1007_3ecc, 2);  jmp(0x1007_3edc, 0xe); goto l_0x1007_3edc;/* jmp 0x10073edc */
        l_0x1007_3ece:
            ii(0x1007_3ece, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3ed1, 5);  call(0x1007_63a0, 0x24ca);            /* call 0x100763a0 */
            ii(0x1007_3ed6, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_3eda, 2);  if(jnz(0x1007_3ede, 2)) goto l_0x1007_3ede;/* jnz 0x10073ede */
        l_0x1007_3edc:
            ii(0x1007_3edc, 2);  jmp(0x1007_3eec, 0xe); goto l_0x1007_3eec;/* jmp 0x10073eec */
        l_0x1007_3ede:
            ii(0x1007_3ede, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3ee1, 5);  call(0x1007_63a0, 0x24ba);            /* call 0x100763a0 */
            ii(0x1007_3ee6, 4);  cmp(memb[ds, eax + 62], 0x1f);        /* cmp byte [eax+0x3e], 0x1f */
            ii(0x1007_3eea, 2);  if(jnz(0x1007_3eee, 2)) goto l_0x1007_3eee;/* jnz 0x10073eee */
        l_0x1007_3eec:
            ii(0x1007_3eec, 2);  jmp(0x1007_3ef4, 6); goto l_0x1007_3ef4;/* jmp 0x10073ef4 */
        l_0x1007_3eee:
            ii(0x1007_3eee, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x1007_3ef1, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
        l_0x1007_3ef4:
            ii(0x1007_3ef4, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3ef7, 5);  call(0x1007_6bf8, 0x2cfc);            /* call 0x10076bf8 */
            ii(0x1007_3efc, 5);  jmp(0x1007_3e58, -0xa9); goto l_0x1007_3e58;/* jmp 0x10073e58 */
        l_0x1007_3f01:
            ii(0x1007_3f01, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1007_3f05, 5);  call(0x1007_1ff5, -0x1f15);           /* call 0x10071ff5 */
            ii(0x1007_3f0a, 3);  mov(edx, memd[ss, ebp - 24]);         /* mov edx, [ebp-0x18] */
            ii(0x1007_3f0d, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x1007_3f10, 3);  mov(memd[ss, ebp - 28], edx);         /* mov [ebp-0x1c], edx */
            ii(0x1007_3f13, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3f15, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x1007_3f18, 5);  call(0x1007_5f6c, 0x204f);            /* call 0x10075f6c */
            ii(0x1007_3f1d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_3f1f, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_3f22, 5);  call(0x1007_5eac, 0x1f85);            /* call 0x10075eac */
            ii(0x1007_3f27, 2);  jmp(0x1007_3f3d, 0x14); goto l_0x1007_3f3d;/* jmp 0x10073f3d */
        //  ii(0x1007_3f29, 20);  Недостижимый код.
        l_0x1007_3f3d:
            ii(0x1007_3f3d, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1007_3f40, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_3f42, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_3f43, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_3f44, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_3f45, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_3f46, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_3f47, 1);  ret();                                /* ret */
        }
    }
}
