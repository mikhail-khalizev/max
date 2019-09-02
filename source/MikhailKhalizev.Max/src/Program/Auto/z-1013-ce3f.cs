using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ce3f-4192b1dc")]
        public void Method_1013_ce3f()
        {
            ii(0x1013_ce3f, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_ce44, 5); call(Definitions.sys_check_available_stack_size, 0x2_8f09); /* call 0x10165d52 */
            ii(0x1013_ce49, 1); push(ebx);                              /* push ebx */
            ii(0x1013_ce4a, 1); push(ecx);                              /* push ecx */
            ii(0x1013_ce4b, 1); push(esi);                              /* push esi */
            ii(0x1013_ce4c, 1); push(edi);                              /* push edi */
            ii(0x1013_ce4d, 1); push(ebp);                              /* push ebp */
            ii(0x1013_ce4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ce50, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_ce56, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_ce59, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_ce5c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ce5f, 6); cmp(memd[ds, eax], 0xffff);             /* cmp dword [eax], 0xffff */
            ii(0x1013_ce65, 2); if(jz(0x1013_ce73, 0xc)) goto l_0x1013_ce73; /* jz 0x1013ce73 */
            ii(0x1013_ce67, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ce6a, 7); cmp(memd[ds, eax + 28], 0xffff);        /* cmp dword [eax+0x1c], 0xffff */
            ii(0x1013_ce71, 2); if(jnz(0x1013_ce75, 2)) goto l_0x1013_ce75; /* jnz 0x1013ce75 */
        l_0x1013_ce73:
            ii(0x1013_ce73, 2); jmp(0x1013_cebf, 0x4a); goto l_0x1013_cebf; /* jmp 0x1013cebf */
        l_0x1013_ce75:
            ii(0x1013_ce75, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ce78, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_ce7a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ce7d, 3); mov(eax, memd[ds, eax + 28]);           /* mov eax, [eax+0x1c] */
            ii(0x1013_ce80, 5); call(/* sys */ 0x1018_0376, 0x4_34f1);  /* call 0x10180376 */
            ii(0x1013_ce85, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ce88, 4); cmp(memd[ds, eax + 11], 0);             /* cmp dword [eax+0xb], 0x0 */
            ii(0x1013_ce8c, 2); if(jnz(0x1013_ce98, 0xa)) goto l_0x1013_ce98; /* jnz 0x1013ce98 */
            ii(0x1013_ce8e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ce91, 5); cmp(memw[ds, eax + 15], 0);             /* cmp word [eax+0xf], 0x0 */
            ii(0x1013_ce96, 2); if(jz(0x1013_cea3, 0xb)) goto l_0x1013_cea3; /* jz 0x1013cea3 */
        l_0x1013_ce98:
            ii(0x1013_ce98, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ce9b, 3); mov(eax, memd[ds, eax + 11]);           /* mov eax, [eax+0xb] */
            ii(0x1013_ce9e, 5); call(Definitions.sys_delete, 0x2_90c1); /* call 0x10165f64 */
        l_0x1013_cea3:
            ii(0x1013_cea3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_cea6, 6); mov(memw[ds, eax + 15], 0);             /* mov word [eax+0xf], 0x0 */
            ii(0x1013_ceac, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ceaf, 7); mov(memd[ds, eax + 11], 0);             /* mov dword [eax+0xb], 0x0 */
            ii(0x1013_ceb6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ceb9, 6); mov(memd[ds, eax], 0xffff);             /* mov dword [eax], 0xffff */
        l_0x1013_cebf:
            ii(0x1013_cebf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_cec1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_cec2, 1); pop(edi);                               /* pop edi */
            ii(0x1013_cec3, 1); pop(esi);                               /* pop esi */
            ii(0x1013_cec4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_cec5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_cec6, 1); ret();                                  /* ret */
        }
    }
}
