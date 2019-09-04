using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_add4-51248166")]
        public void Method_1013_add4()
        {
            ii(0x1013_add4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_add9, 5); call(Definitions.sys_check_available_stack_size, 0x2_af74); /* call 0x10165d52 */
            ii(0x1013_adde, 1); push(ebx);                              /* push ebx */
            ii(0x1013_addf, 1); push(ecx);                              /* push ecx */
            ii(0x1013_ade0, 1); push(edx);                              /* push edx */
            ii(0x1013_ade1, 1); push(esi);                              /* push esi */
            ii(0x1013_ade2, 1); push(edi);                              /* push edi */
            ii(0x1013_ade3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_ade4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ade6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_adec, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_adef, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_adf3, 2); if(jz(0x1013_ae1e, 0x29)) goto l_0x1013_ae1e; /* jz 0x1013ae1e */
            ii(0x1013_adf5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_adf8, 3); dec(memw[ds, eax]);                     /* dec word [eax] */
            ii(0x1013_adfb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_adfe, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1013_ae01, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_ae03, 2); if(jnz(0x1013_ae1e, 0x19)) goto l_0x1013_ae1e; /* jnz 0x1013ae1e */
            ii(0x1013_ae05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ae08, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_ae0b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_ae0e, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1013_ae11, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1013_ae16, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_ae19, 2); call_abs(memd[ds, ebx]);                /* call dword [ebx] */
            ii(0x1013_ae1b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1013_ae1e:
            ii(0x1013_ae1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ae20, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ae21, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ae22, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ae23, 1); pop(edx);                               /* pop edx */
            ii(0x1013_ae24, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ae25, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ae26, 1); ret();                                  /* ret */
        }
    }
}
