using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_4319-22fcac55")]
        public void Method_1012_4319()
        {
            ii(0x1012_4319, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1012_431e, 5); calld(Definitions.sys_check_available_stack_size, 0x4_1a2f); /* call 0x10165d52 */
            ii(0x1012_4323, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_4324, 1); pushd(esi);                             /* push esi */
            ii(0x1012_4325, 1); pushd(edi);                             /* push edi */
            ii(0x1012_4326, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_4327, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_4329, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_432f, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x1012_4332, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4333, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4336, 1); pushd(eax);                             /* push eax */
            ii(0x1012_4337, 5); calld(0x1012_36fa, -0xc42);             /* call 0x101236fa */
            ii(0x1012_433c, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1012_433f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_4341, 2); if(jnzd(0x1012_434f, 0xc)) goto l_0x1012_434f; /* jnz 0x1012434f */
            ii(0x1012_4343, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_434a, 5); jmpd(0x1012_43ce, 0x7f); goto l_0x1012_43ce; /* jmp 0x101243ce */
        l_0x1012_434f:
            ii(0x1012_434f, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4352, 6); mov(eax, memd_a32[ds, eax + 0x98]);     /* mov eax, [eax+0x98] */
            ii(0x1012_4358, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_435b, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_435e, 6); mov(edx, memd_a32[ds, eax + 0x84]);     /* mov edx, [eax+0x84] */
            ii(0x1012_4364, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_4367, 6); mov(eax, memd_a32[ds, eax + 0x88]);     /* mov eax, [eax+0x88] */
            ii(0x1012_436d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_436f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_4372, 7); mov(memd_a32[ss, ebp - 0x4], 0x1);      /* mov dword [ebp-0x4], 0x1 */
        l_0x1012_4379:
            ii(0x1012_4379, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_437c, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_437f, 3); cmp(memb_a32[ds, eax], 0x5b);           /* cmp byte [eax], 0x5b */
            ii(0x1012_4382, 2); if(jzd(0x1012_438f, 0xb)) goto l_0x1012_438f; /* jz 0x1012438f */
            ii(0x1012_4384, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_4387, 3); add(eax, memd_a32[ss, ebp - 0x4]);      /* add eax, [ebp-0x4] */
            ii(0x1012_438a, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1012_438d, 2); if(jbd(0x1012_4391, 0x2)) goto l_0x1012_4391; /* jb 0x10124391 */
        l_0x1012_438f:
            ii(0x1012_438f, 2); jmpd(0x1012_4399, 0x8); goto l_0x1012_4399; /* jmp 0x10124399 */
        l_0x1012_4391:
            ii(0x1012_4391, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_4394, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
            ii(0x1012_4397, 2); jmpd(0x1012_4379, -0x20); goto l_0x1012_4379; /* jmp 0x10124379 */
        l_0x1012_4399:
            ii(0x1012_4399, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1012_439c, 3); add(ebx, memd_a32[ss, ebp - 0x4]);      /* add ebx, [ebp-0x4] */
            ii(0x1012_439f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_43a2, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1012_43a4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1012_43a6, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_43a9, 3); add(edx, memd_a32[ss, ebp - 0x4]);      /* add edx, [ebp-0x4] */
            ii(0x1012_43ac, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_43af, 5); calld(/* sys */ 0x1016_6177, 0x4_1dc3); /* call 0x10166177 */
            ii(0x1012_43b4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_43b7, 3); mov(edx, memd_a32[ss, ebp + 0x14]);     /* mov edx, [ebp+0x14] */
            ii(0x1012_43ba, 6); sub(memd_a32[ds, edx + 0x88], eax);     /* sub [edx+0x88], eax */
            ii(0x1012_43c0, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_43c3, 4); or(memb_a32[ds, eax + 0x1], -0x80 /* 0x80 */); /* or byte [eax+0x1], 0x80 */
            ii(0x1012_43c7, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
        l_0x1012_43ce:
            ii(0x1012_43ce, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_43d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_43d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_43d4, 1); popd(edi);                              /* pop edi */
            ii(0x1012_43d5, 1); popd(esi);                              /* pop esi */
            ii(0x1012_43d6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_43d7, 1); retd(); return;                         /* ret */
        }
    }
}
