using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_01a3-1948559d")]
        public void Method_100d_01a3()
        {
            ii(0x100d_01a3, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_01a8, 5); calld(Definitions.sys_check_available_stack_size, 0x9_5ba5); /* call 0x10165d52 */
            ii(0x100d_01ad, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_01ae, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_01af, 1); pushd(esi);                             /* push esi */
            ii(0x100d_01b0, 1); pushd(edi);                             /* push edi */
            ii(0x100d_01b1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_01b2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_01b4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_01ba, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_01bd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_01c0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_01c3, 4); mov(ax, memw_a32[ds, eax + 0x24]);      /* mov ax, [eax+0x24] */
            ii(0x100d_01c7, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100d_01cb, 2); if(jled(0x100d_01d7, 0xa)) goto l_0x100d_01d7; /* jle 0x100d01d7 */
            ii(0x100d_01cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_01d0, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_01d3, 4); mov(memw_a32[ds, edx + 0x24], ax);      /* mov [edx+0x24], ax */
        l_0x100d_01d7:
            ii(0x100d_01d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_01da, 3); mov(edx, memd_a32[ds, eax + 0x22]);     /* mov edx, [eax+0x22] */
            ii(0x100d_01dd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_01e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_01e3, 3); mov(eax, memd_a32[ds, eax + 0x26]);     /* mov eax, [eax+0x26] */
            ii(0x100d_01e6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_01e9, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_01eb, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_01ef, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_01f1, 2); if(jgd(0x100d_0205, 0x12)) goto l_0x100d_0205; /* jg 0x100d0205 */
            ii(0x100d_01f3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_01f6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100d_01f9, 4); sub(dx, memw_a32[ds, eax + 0x28]);      /* sub dx, [eax+0x28] */
            ii(0x100d_01fd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0200, 1); inc(edx);                               /* inc edx */
            ii(0x100d_0201, 4); mov(memw_a32[ds, eax + 0x24], dx);      /* mov [eax+0x24], dx */
        l_0x100d_0205:
            ii(0x100d_0205, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0208, 3); mov(edx, memd_a32[ds, eax + 0x22]);     /* mov edx, [eax+0x22] */
            ii(0x100d_020b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_020e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0211, 3); mov(eax, memd_a32[ds, eax + 0x26]);     /* mov eax, [eax+0x26] */
            ii(0x100d_0214, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_0217, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_0219, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_021c, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_021f, 5); calld(Definitions.my_2_get_count, -0x4_4ebc); /* call 0x1008b368 */
            ii(0x100d_0224, 1); cwde();                                 /* cwde */
            ii(0x100d_0225, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100d_0227, 2); if(jled(0x100d_0246, 0x1d)) goto l_0x100d_0246; /* jle 0x100d0246 */
            ii(0x100d_0229, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_022c, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_022f, 5); calld(Definitions.my_2_get_count, -0x4_4ecc); /* call 0x1008b368 */
            ii(0x100d_0234, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_0236, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0239, 4); mov(bx, memw_a32[ds, eax + 0x28]);      /* mov bx, [eax+0x28] */
            ii(0x100d_023d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0240, 2); sub(edx, ebx);                          /* sub edx, ebx */
            ii(0x100d_0242, 4); mov(memw_a32[ds, eax + 0x24], dx);      /* mov [eax+0x24], dx */
        l_0x100d_0246:
            ii(0x100d_0246, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0249, 3); mov(eax, memd_a32[ds, eax + 0x22]);     /* mov eax, [eax+0x22] */
            ii(0x100d_024c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_024f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_0251, 2); if(jged(0x100d_025c, 0x9)) goto l_0x100d_025c; /* jge 0x100d025c */
            ii(0x100d_0253, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_0256, 6); mov(memw_a32[ds, eax + 0x24], 0);       /* mov word [eax+0x24], 0x0 */
        l_0x100d_025c:
            ii(0x100d_025c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_025e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_025f, 1); popd(edi);                              /* pop edi */
            ii(0x100d_0260, 1); popd(esi);                              /* pop esi */
            ii(0x100d_0261, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_0262, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_0263, 1); retd();                                 /* ret */
        }
    }
}
