using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a39fde33-ec4c-49c7-a7f0-563666f3add8")]
        public void Method_1012_3398()
        {
            ii(0x1012_3398, 5); pushd(0x18);                            /* push 0x18 */
            ii(0x1012_339d, 5); calld(Definitions.sys_check_available_stack_size, 0x429b0); /* call 0x10165d52 */
            ii(0x1012_33a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_33a3, 1); pushd(esi);                             /* push esi */
            ii(0x1012_33a4, 1); pushd(edi);                             /* push edi */
            ii(0x1012_33a5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_33a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_33a8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1012_33ae, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33b1, 4); mov(memb_a32[ds, eax + 0x4], 0);        /* mov byte [eax+0x4], 0x0 */
            ii(0x1012_33b5, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_33b9, 5); calld(0x1013_433e, 0x10f80);            /* call 0x1013433e */
            ii(0x1012_33be, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_33c0, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33c3, 6); mov(memd_a32[ds, eax + 0x88], edx);     /* mov [eax+0x88], edx */
            ii(0x1012_33c9, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33cc, 6); mov(edx, memd_a32[ds, eax + 0x88]);     /* mov edx, [eax+0x88] */
            ii(0x1012_33d2, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33d5, 6); mov(memd_a32[ds, eax + 0x8c], edx);     /* mov [eax+0x8c], edx */
            ii(0x1012_33db, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_33df, 5); calld(Definitions.my_get_res_data_by_id_malloc, 0x10e07); /* call 0x101341eb */
            ii(0x1012_33e4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_33e6, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33e9, 6); mov(memd_a32[ds, eax + 0x84], edx);     /* mov [eax+0x84], edx */
            ii(0x1012_33ef, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_33f2, 7); cmp(memd_a32[ds, eax + 0x84], 0);       /* cmp dword [eax+0x84], 0x0 */
            ii(0x1012_33f9, 2); if(jnzd(0x1012_3404, 0x9)) goto l_0x1012_3404; /* jnz 0x10123404 */
            ii(0x1012_33fb, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x1012_3402, 2); jmpd(0x1012_3465, 0x61); goto l_0x1012_3465; /* jmp 0x10123465 */
        l_0x1012_3404:
            ii(0x1012_3404, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3407, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_340d, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3410, 6); mov(memd_a32[ds, eax + 0x90], edx);     /* mov [eax+0x90], edx */
            ii(0x1012_3416, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3419, 10); mov(memd_a32[ds, eax + 0x94], 0);      /* mov dword [eax+0x94], 0x0 */
            ii(0x1012_3423, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3426, 10); mov(memd_a32[ds, eax + 0xa0], 0);      /* mov dword [eax+0xa0], 0x0 */
            ii(0x1012_3430, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3433, 10); mov(memd_a32[ds, eax + 0xa4], 0);      /* mov dword [eax+0xa4], 0x0 */
            ii(0x1012_343d, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_3440, 10); mov(memd_a32[ds, eax + 0x9c], 0);      /* mov dword [eax+0x9c], 0x0 */
            ii(0x1012_344a, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_344d, 10); mov(memd_a32[ds, eax + 0xa8], 0);      /* mov dword [eax+0xa8], 0x0 */
            ii(0x1012_3457, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_345a, 4); and(memb_a32[ds, eax + 0x1], 0x7f);     /* and byte [eax+0x1], 0x7f */
            ii(0x1012_345e, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_3465:
            ii(0x1012_3465, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_3468, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_346a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_346b, 1); popd(edi);                              /* pop edi */
            ii(0x1012_346c, 1); popd(esi);                              /* pop esi */
            ii(0x1012_346d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_346e, 1); retd(); return;                         /* ret */
        }
    }
}
