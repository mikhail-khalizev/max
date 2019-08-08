using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c9737bf-e46d-4874-95a8-84500513f405")]
        public void Method_1012_e6a8()
        {
            ii(0x1012_e6a8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_e6ad, 5); calld(Definitions.sys_check_available_stack_size, 0x3_76a0); /* call 0x10165d52 */
            ii(0x1012_e6b2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_e6b3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_e6b4, 1); pushd(esi);                             /* push esi */
            ii(0x1012_e6b5, 1); pushd(edi);                             /* push edi */
            ii(0x1012_e6b6, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_e6b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_e6b9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_e6bf, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_e6c2, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_e6c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e6c8, 3); mov(ebx, memd_a32[ds, eax + 0x38]);     /* mov ebx, [eax+0x38] */
            ii(0x1012_e6cb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_e6ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e6d1, 6); mov(eax, memd_a32[ds, eax + 0xde]);     /* mov eax, [eax+0xde] */
            ii(0x1012_e6d7, 5); calld(0x100d_4f24, -0x5_97b8);          /* call 0x100d4f24 */
            ii(0x1012_e6dc, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_e6df, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_e6e1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_e6e4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_e6e6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_e6e9, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e6ed, 3); sub(edx, 0x32);                         /* sub edx, 0x32 */
            ii(0x1012_e6f0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_e6f2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_e6f5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_e6f7, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1012_e6f9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e6fb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e6fe, 6); mov(eax, memd_a32[ds, eax + 0xde]);     /* mov eax, [eax+0xde] */
            ii(0x1012_e704, 5); calld(0x100d_4ebc, -0x5_984d);          /* call 0x100d4ebc */
            ii(0x1012_e709, 1); cwde();                                 /* cwde */
            ii(0x1012_e70a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_e70c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_e70f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_e712, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x1012_e716, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1012_e71a, 2); if(jld(0x1012_e76d, 0x51)) goto l_0x1012_e76d; /* jl 0x1012e76d */
            ii(0x1012_e71c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_e71f, 2); mov(eax, memd_a32[ds, edx]);            /* mov eax, [edx] */
            ii(0x1012_e721, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_e724, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1012_e728, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1012_e72a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_e72c, 4); movsx(ebx, memw_a32[ss, ebp - 0xc]);    /* movsx ebx, word [ebp-0xc] */
            ii(0x1012_e730, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_e732, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_e735, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_e737, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_e73a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_e73d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_e740, 4); cmp(ax, memw_a32[ds, edx + 0x3a]);      /* cmp ax, [edx+0x3a] */
            ii(0x1012_e744, 2); if(jged(0x1012_e76d, 0x27)) goto l_0x1012_e76d; /* jge 0x1012e76d */
            ii(0x1012_e746, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e749, 4); mov(ax, memw_a32[ds, eax + 0x30]);      /* mov ax, [eax+0x30] */
            ii(0x1012_e74d, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x1012_e750, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e753, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x1012_e756, 5); calld(Definitions.my_1_get_count, -0x8_3283); /* call 0x100ab4d8 */
            ii(0x1012_e75b, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1012_e75f, 2); if(jled(0x1012_e76d, 0xc)) goto l_0x1012_e76d; /* jle 0x1012e76d */
            ii(0x1012_e761, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x1012_e765, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_e768, 5); calld(0x1012_e1cf, -0x59e);             /* call 0x1012e1cf */
        l_0x1012_e76d:
            ii(0x1012_e76d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_e76f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_e770, 1); popd(edi);                              /* pop edi */
            ii(0x1012_e771, 1); popd(esi);                              /* pop esi */
            ii(0x1012_e772, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_e773, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_e774, 1); retd(); return;                         /* ret */
        }
    }
}
