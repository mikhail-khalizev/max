using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5d49-e03b2413")]
        public void Method_1014_5d49()
        {
            ii(0x1014_5d49, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1014_5d4e, 5);  call(Definitions.sys_check_available_stack_size, 0x1_ffff);/* call 0x10165d52 */
            ii(0x1014_5d53, 1);  push(esi);                            /* push esi */
            ii(0x1014_5d54, 1);  push(edi);                            /* push edi */
            ii(0x1014_5d55, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5d56, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5d58, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1014_5d5e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_5d61, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1014_5d64, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_5d67, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1014_5d6a, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1014_5d6d, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1014_5d70, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_5d73, 5);  call(0x1014_630a, 0x592);             /* call 0x1014630a */
            ii(0x1014_5d78, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5d7a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d7d, 5);  call(0x1013_ad11, -0xb071);           /* call 0x1013ad11 */
            ii(0x1014_5d82, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_5d84, 2);  if(jz(0x1014_5d96, 0x10)) goto l_0x1014_5d96;/* jz 0x10145d96 */
            ii(0x1014_5d86, 4);  mov(memb[ss, ebp - 20], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x1014_5d8a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5d8c, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d8f, 5);  call(0x100e_03bc, -0x6_59d8);         /* call 0x100e03bc */
            ii(0x1014_5d94, 2);  jmp(0x1014_5de9, 0x53); goto l_0x1014_5de9;/* jmp 0x10145de9 */
        l_0x1014_5d96:
            ii(0x1014_5d96, 4);  movsx(ecx, memw[ss, ebp - 4]);        /* movsx ecx, word [ebp-0x4] */
            ii(0x1014_5d9a, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d9d, 5);  call(0x100e_0760, -0x6_5642);         /* call 0x100e0760 */
            ii(0x1014_5da2, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1014_5da5, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_5da8, 3);  mov(ebx, memd[ds, eax + 2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_5dab, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x1014_5dae, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x1014_5db1, 3);  call_abs(memd[ds, ebx + 8]);          /* call dword [ebx+0x8] */
            ii(0x1014_5db4, 5);  call(Definitions.my_strobj_c_str_v2, -0xb_c5f1);/* call 0x100897c8 */
            ii(0x1014_5db9, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_5dbb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5dbe, 2);  mov(ebx, ecx);                        /* mov ebx, ecx */
            ii(0x1014_5dc0, 5);  call(Definitions.sys_strncpy, 0x2_c11b);/* call 0x10171ee0 */
            ii(0x1014_5dc5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5dc7, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x1014_5dca, 5);  call(Definitions.my_string_dtor, -0x42a5);/* call 0x10141b2a */
            ii(0x1014_5dcf, 4);  mov(memb[ss, ebp - 20], 1);           /* mov byte [ebp-0x14], 0x1 */
            ii(0x1014_5dd3, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5dd5, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5dd8, 5);  call(0x100e_03bc, -0x6_5a21);         /* call 0x100e03bc */
            ii(0x1014_5ddd, 2);  jmp(0x1014_5de9, 0xa); goto l_0x1014_5de9;/* jmp 0x10145de9 */
        //  ii(0x1014_5ddf, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1014_5de1, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
        //  ii(0x1014_5de4, 5);  call(0x100e_03bc, -0x6_5a2d);         /* call 0x100e03bc */
        l_0x1014_5de9:
            ii(0x1014_5de9, 3);  mov(al, memb[ss, ebp - 20]);          /* mov al, [ebp-0x14] */
            ii(0x1014_5dec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5dee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5def, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5df0, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5df1, 1);  ret();                                /* ret */
        }
    }
}
