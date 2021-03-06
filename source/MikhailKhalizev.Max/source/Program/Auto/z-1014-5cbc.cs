using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5cbc-8c3ef066")]
        public void Method_1014_5cbc()
        {
            ii(0x1014_5cbc, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1014_5cc1, 5);  call(Definitions.sys_check_available_stack_size, 0x2_008c);/* call 0x10165d52 */
            ii(0x1014_5cc6, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_5cc7, 1);  push(esi);                            /* push esi */
            ii(0x1014_5cc8, 1);  push(edi);                            /* push edi */
            ii(0x1014_5cc9, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5cca, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5ccc, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1014_5cd2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_5cd5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_5cd8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_5cdb, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_5cde, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1014_5ce1, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_5ce4, 5);  call(0x1014_630a, 0x621);             /* call 0x1014630a */
            ii(0x1014_5ce9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5ceb, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5cee, 5);  call(0x1013_ad11, -0xafe2);           /* call 0x1013ad11 */
            ii(0x1014_5cf3, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_5cf5, 2);  if(jz(0x1014_5d07, 0x10)) goto l_0x1014_5d07;/* jz 0x10145d07 */
            ii(0x1014_5cf7, 4);  mov(memb[ss, ebp - 16], 0);           /* mov byte [ebp-0x10], 0x0 */
            ii(0x1014_5cfb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5cfd, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d00, 5);  call(0x100e_03bc, -0x6_5949);         /* call 0x100e03bc */
            ii(0x1014_5d05, 2);  jmp(0x1014_5d3f, 0x38); goto l_0x1014_5d3f;/* jmp 0x10145d3f */
        l_0x1014_5d07:
            ii(0x1014_5d07, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d0a, 5);  call(0x100e_0760, -0x6_55af);         /* call 0x100e0760 */
            ii(0x1014_5d0f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_5d12, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_5d15, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1014_5d18, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_5d1b, 3);  call_abs(memd[ds, edx + 4]);          /* call dword [edx+0x4] */
            ii(0x1014_5d1e, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_5d20, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_5d23, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1014_5d25, 4);  mov(memb[ss, ebp - 16], 1);           /* mov byte [ebp-0x10], 0x1 */
            ii(0x1014_5d29, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_5d2b, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_5d2e, 5);  call(0x100e_03bc, -0x6_5977);         /* call 0x100e03bc */
            ii(0x1014_5d33, 2);  jmp(0x1014_5d3f, 0xa); goto l_0x1014_5d3f;/* jmp 0x10145d3f */
        //  ii(0x1014_5d35, 10);  Недостижимый код.
        l_0x1014_5d3f:
            ii(0x1014_5d3f, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1014_5d42, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5d44, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5d45, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5d46, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5d47, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_5d48, 1);  ret();                                /* ret */
        }
    }
}
