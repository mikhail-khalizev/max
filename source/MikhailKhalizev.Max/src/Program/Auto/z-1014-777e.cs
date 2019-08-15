using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5261d7ca-4173-47d2-9bc1-c7c647e43717")]
        public void Method_1014_777e()
        {
            ii(0x1014_777e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_7783, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e5ca); /* call 0x10165d52 */
            ii(0x1014_7788, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7789, 1); pushd(esi);                             /* push esi */
            ii(0x1014_778a, 1); pushd(edi);                             /* push edi */
            ii(0x1014_778b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_778c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_778e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7794, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_7797, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1014_779a, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1014_779d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_77a0, 5); calld(0x1014_7395, -0x410);             /* call 0x10147395 */
            ii(0x1014_77a5, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_77a8, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_77aa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_77ad, 5); calld(/* sys */ 0x1018_0f4d, 0x3_979b); /* call 0x10180f4d */
            ii(0x1014_77b2, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_77b5, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_77b7, 5); mov(eax, StringDefinitions.Control42);  /* mov eax, 0x101ad160 */
            ii(0x1014_77bc, 5); calld(/* sys */ 0x1018_0f4d, 0x3_978c); /* call 0x10180f4d */
            ii(0x1014_77c1, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1014_77c5, 2); if(jzd(0x1014_77d8, 0x11)) goto l_0x1014_77d8; /* jz 0x101477d8 */
            ii(0x1014_77c7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_77ca, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_77cc, 5); mov(eax, StringDefinitions.True3);      /* mov eax, 0x101ad164 */
            ii(0x1014_77d1, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9777); /* call 0x10180f4d */
            ii(0x1014_77d6, 2); jmpd(0x1014_77e7, 0xf); goto l_0x1014_77e7; /* jmp 0x101477e7 */
        l_0x1014_77d8:
            ii(0x1014_77d8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_77db, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_77dd, 5); mov(eax, StringDefinitions.False3);     /* mov eax, 0x101ad16a */
            ii(0x1014_77e2, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9766); /* call 0x10180f4d */
        l_0x1014_77e7:
            ii(0x1014_77e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_77e9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_77ea, 1); popd(edi);                              /* pop edi */
            ii(0x1014_77eb, 1); popd(esi);                              /* pop esi */
            ii(0x1014_77ec, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_77ed, 1); retd(); return;                         /* ret */
        }
    }
}
