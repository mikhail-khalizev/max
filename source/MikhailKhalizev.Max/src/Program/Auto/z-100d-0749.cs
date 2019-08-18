using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0749-2cd6de3c")]
        public void Method_100d_0749()
        {
            ii(0x100d_0749, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_074e, 5); calld(Definitions.sys_check_available_stack_size, 0x9_55ff); /* call 0x10165d52 */
            ii(0x100d_0753, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_0754, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_0755, 1); pushd(edx);                             /* push edx */
            ii(0x100d_0756, 1); pushd(esi);                             /* push esi */
            ii(0x100d_0757, 1); pushd(edi);                             /* push edi */
            ii(0x100d_0758, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_0759, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_075b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_0761, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_0764, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_0767, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_076a, 5); calld(Definitions.my_2_get_count, -0x4_5407); /* call 0x1008b368 */
            ii(0x100d_076f, 1); cwde();                                 /* cwde */
            ii(0x100d_0770, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_0772, 6); if(jzd(0x100d_07fa, 0x82)) goto l_0x100d_07fa; /* jz 0x100d07fa */
            ii(0x100d_0778, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_077b, 3); mov(edx, memd_a32[ds, eax + 0x24]);     /* mov edx, [eax+0x24] */
            ii(0x100d_077e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_0781, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_0784, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0787, 5); calld(0x1008_b32c, -0x4_5460);          /* call 0x1008b32c */
            ii(0x100d_078c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_078f, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_0792, 5); calld(Definitions.my_2_get_count, -0x4_542f); /* call 0x1008b368 */
            ii(0x100d_0797, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_0799, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_079c, 4); cmp(dx, memw_a32[ds, eax + 0x26]);      /* cmp dx, [eax+0x26] */
            ii(0x100d_07a0, 2); if(jgd(0x100d_07cd, 0x2b)) goto l_0x100d_07cd; /* jg 0x100d07cd */
            ii(0x100d_07a2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07a5, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_07a8, 5); calld(Definitions.my_2_get_count, -0x4_5445); /* call 0x1008b368 */
            ii(0x100d_07ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_07af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07b2, 1); dec(edx);                               /* dec edx */
            ii(0x100d_07b3, 4); mov(memw_a32[ds, eax + 0x26], dx);      /* mov [eax+0x26], dx */
            ii(0x100d_07b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07ba, 3); mov(eax, memd_a32[ds, eax + 0x24]);     /* mov eax, [eax+0x24] */
            ii(0x100d_07bd, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_07c0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_07c2, 2); if(jged(0x100d_07cd, 0x9)) goto l_0x100d_07cd; /* jge 0x100d07cd */
            ii(0x100d_07c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07c7, 6); mov(memw_a32[ds, eax + 0x26], 0);       /* mov word [eax+0x26], 0x0 */
        l_0x100d_07cd:
            ii(0x100d_07cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_07cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07d2, 5); calld(0x100d_0617, -0x1c0);             /* call 0x100d0617 */
            ii(0x100d_07d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07da, 3); mov(edx, memd_a32[ds, eax + 0x24]);     /* mov edx, [eax+0x24] */
            ii(0x100d_07dd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_07e0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07e3, 5); calld(0x100d_01a3, -0x645);             /* call 0x100d01a3 */
            ii(0x100d_07e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_07eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_07ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_07f1, 3); mov(edx, memd_a32[ds, eax + 0x40]);     /* mov edx, [eax+0x40] */
            ii(0x100d_07f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_07f7, 3); calld_abs(memd_a32[ds, edx + 0x10]);    /* call dword [edx+0x10] */
        l_0x100d_07fa:
            ii(0x100d_07fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_07fc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_07fd, 1); popd(edi);                              /* pop edi */
            ii(0x100d_07fe, 1); popd(esi);                              /* pop esi */
            ii(0x100d_07ff, 1); popd(edx);                              /* pop edx */
            ii(0x100d_0800, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_0801, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_0802, 1); retd(); return;                         /* ret */
        }
    }
}
