using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cdc5-60f0856a")]
        public void Method_1009_cdc5()
        {
            ii(0x1009_cdc5, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_cdca, 5);  call(Definitions.sys_check_available_stack_size, 0xc_8f83);/* call 0x10165d52 */
            ii(0x1009_cdcf, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_cdd0, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_cdd1, 1);  push(esi);                            /* push esi */
            ii(0x1009_cdd2, 1);  push(edi);                            /* push edi */
            ii(0x1009_cdd3, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_cdd4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_cdd6, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_cddc, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_cddf, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_cde2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_cde5, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_cde8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_cdeb, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_cdee, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_cdf1, 3);  call_abs(memd[ds, edx + 32]);         /* call dword [edx+0x20] */
            ii(0x1009_cdf4, 2);  cmp(al, 0x19);                        /* cmp al, 0x19 */
            ii(0x1009_cdf6, 2);  if(jnz(0x1009_ce15, 0x1d)) goto l_0x1009_ce15;/* jnz 0x1009ce15 */
            ii(0x1009_cdf8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_cdfb, 4);  dec(memw[ds, eax + 33]);              /* dec word [eax+0x21] */
            ii(0x1009_cdff, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ce02, 3);  mov(eax, memd[ds, eax + 31]);         /* mov eax, [eax+0x1f] */
            ii(0x1009_ce05, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_ce08, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1009_ce0a, 2);  if(jge(0x1009_ce15, 9)) goto l_0x1009_ce15;/* jge 0x1009ce15 */
            ii(0x1009_ce0c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ce0f, 6);  mov(memw[ds, eax + 33], 0);           /* mov word [eax+0x21], 0x0 */
        l_0x1009_ce15:
            ii(0x1009_ce15, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_ce17, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_ce18, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_ce19, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_ce1a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_ce1b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_ce1c, 1);  ret();                                /* ret */
        }
    }
}
