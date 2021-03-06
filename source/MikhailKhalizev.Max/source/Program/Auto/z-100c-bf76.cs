using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_bf76-99f3980f")]
        public void Method_100c_bf76()
        {
            ii(0x100c_bf76, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_bf7b, 5);  call(Definitions.sys_check_available_stack_size, 0x9_9dd2);/* call 0x10165d52 */
            ii(0x100c_bf80, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_bf81, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_bf82, 1);  push(edx);                            /* push edx */
            ii(0x100c_bf83, 1);  push(esi);                            /* push esi */
            ii(0x100c_bf84, 1);  push(edi);                            /* push edi */
            ii(0x100c_bf85, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_bf86, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_bf88, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_bf8e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_bf91, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bf94, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bf97, 5);  call(0x1007_6574, -0x5_5a28);         /* call 0x10076574 */
            ii(0x100c_bf9c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100c_bf9e, 3);  mov(dl, memb[ds, eax + 77]);          /* mov dl, [eax+0x4d] */
            ii(0x100c_bfa1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bfa4, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bfa7, 5);  call(0x1007_6574, -0x5_5a38);         /* call 0x10076574 */
            ii(0x100c_bfac, 5);  call(0x1007_623c, -0x5_5d75);         /* call 0x1007623c */
            ii(0x100c_bfb1, 3);  mov(eax, memd[ds, eax + 8]);          /* mov eax, [eax+0x8] */
            ii(0x100c_bfb4, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_bfb7, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100c_bfb9, 2);  if(jl(0x100c_bfc4, 9)) goto l_0x100c_bfc4;/* jl 0x100cbfc4 */
            ii(0x100c_bfbb, 7);  mov(memd[ss, ebp - 8], 1);            /* mov dword [ebp-0x8], 0x1 */
            ii(0x100c_bfc2, 2);  jmp(0x100c_bfd7, 0x13); goto l_0x100c_bfd7;/* jmp 0x100cbfd7 */
        l_0x100c_bfc4:
            ii(0x100c_bfc4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_bfc7, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100c_bfca, 5);  call(0x1007_6574, -0x5_5a5b);         /* call 0x10076574 */
            ii(0x100c_bfcf, 5);  call(0x1015_012d, 0x8_4159);          /* call 0x1015012d */
            ii(0x100c_bfd4, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
        l_0x100c_bfd7:
            ii(0x100c_bfd7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_bfda, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_bfdc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_bfdd, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_bfde, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_bfdf, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_bfe0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_bfe1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_bfe2, 1);  ret();                                /* ret */
        }
    }
}
