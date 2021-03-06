using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_1b0f-898ab736")]
        public void Method_100b_1b0f()
        {
            ii(0x100b_1b0f, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_1b14, 5);  call(Definitions.sys_check_available_stack_size, 0xb_4239);/* call 0x10165d52 */
            ii(0x100b_1b19, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_1b1a, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_1b1b, 1);  push(esi);                            /* push esi */
            ii(0x100b_1b1c, 1);  push(edi);                            /* push edi */
            ii(0x100b_1b1d, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_1b1e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_1b20, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100b_1b26, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_1b29, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_1b2c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1b2f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_1b32, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_1b35, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100b_1b38, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_1b3b, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x100b_1b3e, 2);  cmp(al, 0x17);                        /* cmp al, 0x17 */
            ii(0x100b_1b40, 6);  if(jnz(0x100b_1bcb, 0x85)) goto l_0x100b_1bcb;/* jnz 0x100b1bcb */
            ii(0x100b_1b46, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1b49, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_1b4c, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_1b4f, 5);  call(0x100b_7d68, 0x6214);            /* call 0x100b7d68 */
            ii(0x100b_1b54, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_1b56, 2);  if(jz(0x100b_1b68, 0x10)) goto l_0x100b_1b68;/* jz 0x100b1b68 */
            ii(0x100b_1b58, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_1b5b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_1b5e, 5);  call(0x100b_7d68, 0x6205);            /* call 0x100b7d68 */
            ii(0x100b_1b63, 5);  call(0x1015_27b8, 0xa_0c50);          /* call 0x101527b8 */
        l_0x100b_1b68:
            ii(0x100b_1b68, 3);  mov(edx, memd[ss, ebp - 16]);         /* mov edx, [ebp-0x10] */
            ii(0x100b_1b6b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1b6e, 3);  add(eax, 0x19);                       /* add eax, 0x19 */
            ii(0x100b_1b71, 5);  call(0x100b_7bac, 0x6036);            /* call 0x100b7bac */
            ii(0x100b_1b76, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_1b79, 3);  add(edx, 0x23);                       /* add edx, 0x23 */
            ii(0x100b_1b7c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1b7f, 5);  call(0x1007_6d98, -0x3_adec);         /* call 0x10076d98 */
            ii(0x100b_1b84, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_1b86, 2);  if(jz(0x100b_1bcb, 0x43)) goto l_0x100b_1bcb;/* jz 0x100b1bcb */
            ii(0x100b_1b88, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_1b8a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1b8d, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1b90, 5);  call(0x1013_ad71, 0x8_91dc);          /* call 0x1013ad71 */
            ii(0x100b_1b95, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_1b97, 2);  if(jz(0x100b_1bbe, 0x25)) goto l_0x100b_1bbe;/* jz 0x100b1bbe */
            ii(0x100b_1b99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1b9c, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1b9f, 5);  call(0x1007_65d0, -0x3_b5d4);         /* call 0x100765d0 */
            ii(0x100b_1ba4, 5);  call(0x100a_b50c, -0x669d);           /* call 0x100ab50c */
            ii(0x100b_1ba9, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100b_1bae, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1bb1, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x100b_1bb4, 5);  call(0x1007_65d0, -0x3_b5e9);         /* call 0x100765d0 */
            ii(0x100b_1bb9, 5);  call(0x100a_297d, -0xf241);           /* call 0x100a297d */
        l_0x100b_1bbe:
            ii(0x100b_1bbe, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_1bc0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1bc3, 3);  add(eax, 0x23);                       /* add eax, 0x23 */
            ii(0x100b_1bc6, 5);  call(0x100b_7cfc, 0x6131);            /* call 0x100b7cfc */
        l_0x100b_1bcb:
            ii(0x100b_1bcb, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_1bce, 3);  add(edx, 0x27);                       /* add edx, 0x27 */
            ii(0x100b_1bd1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_1bd4, 5);  call(0x1007_6d98, -0x3_ae41);         /* call 0x10076d98 */
            ii(0x100b_1bd9, 2);  test(al, al);                         /* test al, al */
            ii(0x100b_1bdb, 2);  if(jz(0x100b_1bea, 0xd)) goto l_0x100b_1bea;/* jz 0x100b1bea */
            ii(0x100b_1bdd, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_1bdf, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_1be2, 3);  add(eax, 0x27);                       /* add eax, 0x27 */
            ii(0x100b_1be5, 5);  call(0x1008_a898, -0x2_7352);         /* call 0x1008a898 */
        l_0x100b_1bea:
            ii(0x100b_1bea, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_1bec, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_1bed, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_1bee, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_1bef, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_1bf0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_1bf1, 1);  ret();                                /* ret */
        }
    }
}
