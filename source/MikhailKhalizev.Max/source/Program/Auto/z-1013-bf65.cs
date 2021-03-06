using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bf65-ce3b9269")]
        public void Method_1013_bf65()
        {
            ii(0x1013_bf65, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_bf6a, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9de3);/* call 0x10165d52 */
            ii(0x1013_bf6f, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_bf70, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_bf71, 1);  push(esi);                            /* push esi */
            ii(0x1013_bf72, 1);  push(edi);                            /* push edi */
            ii(0x1013_bf73, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_bf74, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_bf76, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_bf7c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bf7f, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bf82, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bf85, 5);  call(0x1013_bfc1, 0x37);              /* call 0x1013bfc1 */
            ii(0x1013_bf8a, 5);  mov(edx, StringDefinitions.Wb);       /* mov edx, 0x101accf6 */
            ii(0x1013_bf8f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_bf92, 5);  call(Definitions.sys_fopen, 0x3_63e3);/* call 0x1017237a */
            ii(0x1013_bf97, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1013_bf99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bf9c, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1013_bf9e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bfa1, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1013_bfa4, 2);  if(jz(0x1013_bfac, 6)) goto l_0x1013_bfac;/* jz 0x1013bfac */
            ii(0x1013_bfa6, 4);  mov(memb[ss, ebp - 12], 1);           /* mov byte [ebp-0xc], 0x1 */
            ii(0x1013_bfaa, 2);  jmp(0x1013_bfb0, 4); goto l_0x1013_bfb0;/* jmp 0x1013bfb0 */
        l_0x1013_bfac:
            ii(0x1013_bfac, 4);  mov(memb[ss, ebp - 12], 0);           /* mov byte [ebp-0xc], 0x0 */
        l_0x1013_bfb0:
            ii(0x1013_bfb0, 3);  mov(al, memb[ss, ebp - 12]);          /* mov al, [ebp-0xc] */
            ii(0x1013_bfb3, 3);  mov(memb[ss, ebp - 16], al);          /* mov [ebp-0x10], al */
            ii(0x1013_bfb6, 3);  mov(al, memb[ss, ebp - 16]);          /* mov al, [ebp-0x10] */
            ii(0x1013_bfb9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_bfbb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_bfbc, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_bfbd, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_bfbe, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_bfbf, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_bfc0, 1);  ret();                                /* ret */
        }
    }
}
