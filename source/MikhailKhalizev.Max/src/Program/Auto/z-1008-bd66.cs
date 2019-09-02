using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bd66-b5183a4e")]
        public void Method_1008_bd66()
        {
            ii(0x1008_bd66, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_bd6b, 5); call(Definitions.sys_check_available_stack_size, 0xd_9fe2); /* call 0x10165d52 */
            ii(0x1008_bd70, 1); push(ebx);                              /* push ebx */
            ii(0x1008_bd71, 1); push(ecx);                              /* push ecx */
            ii(0x1008_bd72, 1); push(edx);                              /* push edx */
            ii(0x1008_bd73, 1); push(esi);                              /* push esi */
            ii(0x1008_bd74, 1); push(edi);                              /* push edi */
            ii(0x1008_bd75, 1); push(ebp);                              /* push ebp */
            ii(0x1008_bd76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_bd78, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_bd7e, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_bd81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_bd83, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_bd86, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_bd89, 5); call(0x1013_ad71, 0xa_efe3);            /* call 0x1013ad71 */
            ii(0x1008_bd8e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_bd90, 2); if(jz(0x1008_bdb1, 0x1f)) goto l_0x1008_bdb1; /* jz 0x1008bdb1 */
            ii(0x1008_bd92, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_bd95, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_bd98, 5); call(0x1008_af28, -0xe75);              /* call 0x1008af28 */
            ii(0x1008_bd9d, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_bda0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_bda3, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1008_bda6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_bda9, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1008_bdac, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_bdaf, 2); jmp(0x1008_bdbb, 0xa); goto l_0x1008_bdbb; /* jmp 0x1008bdbb */
        l_0x1008_bdb1:
            ii(0x1008_bdb1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_bdb4, 4); mov(ax, memw[ds, eax + 0xd]);           /* mov ax, [eax+0xd] */
            ii(0x1008_bdb8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1008_bdbb:
            ii(0x1008_bdbb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_bdbe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_bdc0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_bdc1, 1); pop(edi);                               /* pop edi */
            ii(0x1008_bdc2, 1); pop(esi);                               /* pop esi */
            ii(0x1008_bdc3, 1); pop(edx);                               /* pop edx */
            ii(0x1008_bdc4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_bdc5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_bdc6, 1); ret();                                  /* ret */
        }
    }
}
