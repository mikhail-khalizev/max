using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_fa43-e10ffdc3")]
        public void Method_1014_fa43()
        {
            ii(0x1014_fa43, 5);  push(0x5c);                           /* push 0x5c */
            ii(0x1014_fa48, 5);  call(Definitions.sys_check_available_stack_size, 0x1_6305);/* call 0x10165d52 */
            ii(0x1014_fa4d, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_fa4e, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_fa4f, 1);  push(esi);                            /* push esi */
            ii(0x1014_fa50, 1);  push(edi);                            /* push edi */
            ii(0x1014_fa51, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_fa52, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_fa54, 6);  sub(esp, 0x44);                       /* sub esp, 0x44 */
            ii(0x1014_fa5a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_fa5d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_fa60, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x1014_fa63, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fa66, 5);  call(0x1014_f9cf, -0x9c);             /* call 0x1014f9cf */
            ii(0x1014_fa6b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_fa6e, 3);  add(eax, 0x6c);                       /* add eax, 0x6c */
            ii(0x1014_fa71, 5);  call(0x1007_6730, -0xd_9346);         /* call 0x10076730 */
            ii(0x1014_fa76, 5);  call(0x100e_f36c, -0x6_070f);         /* call 0x100ef36c */
            ii(0x1014_fa7b, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1014_fa7e, 3);  lea(eax, memd[ss, ebp - 68]);         /* lea eax, [ebp-0x44] */
            ii(0x1014_fa81, 5);  call(0x1014_f905, -0x181);            /* call 0x1014f905 */
            ii(0x1014_fa86, 5);  mov(edx, StringDefinitions.Mk);       /* mov edx, 0x101adde3 */
            ii(0x1014_fa8b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fa8e, 5);  call(Definitions.sys_strcpy, 0x1_643c);/* call 0x10165ecf */
            ii(0x1014_fa93, 3);  lea(edx, memd[ss, ebp - 68]);         /* lea edx, [ebp-0x44] */
            ii(0x1014_fa96, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fa99, 5);  call(Definitions.sys_strcat, 0x1_6493);/* call 0x10165f31 */
            ii(0x1014_fa9e, 5);  mov(edx, StringDefinitions.Control18);/* mov edx, 0x101adde7 */
            ii(0x1014_faa3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_faa6, 5);  call(Definitions.sys_strcat, 0x1_6486);/* call 0x10165f31 */
            ii(0x1014_faab, 3);  lea(edx, memd[ss, ebp - 48]);         /* lea edx, [ebp-0x30] */
            ii(0x1014_faae, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_fab1, 5);  call(Definitions.sys_strcat, 0x1_647b);/* call 0x10165f31 */
            ii(0x1014_fab6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_fab8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_fab9, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_faba, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_fabb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_fabc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_fabd, 1);  ret();                                /* ret */
        }
    }
}
