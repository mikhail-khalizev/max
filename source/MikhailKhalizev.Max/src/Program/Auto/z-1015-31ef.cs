using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("61512db2-230b-44ef-a641-1a6406087be9")]
        public void Method_1015_31ef()
        {
            ii(0x1015_31ef, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1015_31f4, 5); calld(Definitions.sys_check_available_stack_size, 0x12b59); /* call 0x10165d52 */
            ii(0x1015_31f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_31fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_31fb, 1); pushd(esi);                             /* push esi */
            ii(0x1015_31fc, 1); pushd(edi);                             /* push edi */
            ii(0x1015_31fd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_31fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3200, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1015_3206, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_3209, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_320c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_320f, 3); mov(ebx, memd_a32[ds, eax + 0x16]);     /* mov ebx, [eax+0x16] */
            ii(0x1015_3212, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3215, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3218, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1015_321b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_321e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1015_3221, 5); calld(0x1007_6aac, -0xdc77a);           /* call 0x10076aac */
            ii(0x1015_3226, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1015_3229, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_322c, 6); mov(ebx, memd_a32[ds, eax + 0xd3]);     /* mov ebx, [eax+0xd3] */
            ii(0x1015_3232, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3235, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_3238, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_323b, 5); calld(0x1007_5e64, -0xdd3dc);           /* call 0x10075e64 */
            ii(0x1015_3240, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3242, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3245, 5); calld(0x1015_3079, -0x1d1);             /* call 0x10153079 */
            ii(0x1015_324a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_324d, 4); test(memb_a32[ds, eax + 0x15], 0xa);    /* test byte [eax+0x15], 0xa */
            ii(0x1015_3251, 2); if(jzd(0x1015_328f, 0x3c)) goto l_0x1015_328f; /* jz 0x1015328f */
            ii(0x1015_3253, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3256, 5); movsx(ax, memb_a32[ds, eax + 0x2f]);    /* movsx ax, byte [eax+0x2f] */
            ii(0x1015_325b, 4); add(memw_a32[ss, ebp - 0x10], ax);      /* add [ebp-0x10], ax */
            ii(0x1015_325f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3262, 5); movsx(ax, memb_a32[ds, eax + 0x30]);    /* movsx ax, byte [eax+0x30] */
            ii(0x1015_3267, 4); add(memw_a32[ss, ebp - 0xe], ax);       /* add [ebp-0xe], ax */
            ii(0x1015_326b, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1015_326e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3271, 6); mov(ebx, memd_a32[ds, eax + 0xd5]);     /* mov ebx, [eax+0xd5] */
            ii(0x1015_3277, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_327a, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1015_327d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1015_3280, 5); calld(0x1007_5e64, -0xdd421);           /* call 0x10075e64 */
            ii(0x1015_3285, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3287, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_328a, 5); calld(0x1015_3079, -0x216);             /* call 0x10153079 */
        l_0x1015_328f:
            ii(0x1015_328f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3291, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_3292, 1); popd(edi);                              /* pop edi */
            ii(0x1015_3293, 1); popd(esi);                              /* pop esi */
            ii(0x1015_3294, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_3295, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_3296, 1); retd(); return;                         /* ret */
        }
    }
}