using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_8583-5fb887a")]
        public void Method_100b_8583()
        {
            ii(0x100b_8583, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100b_8588, 5); calld(Definitions.sys_check_available_stack_size, 0xa_d7c5); /* call 0x10165d52 */
            ii(0x100b_858d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_858e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_858f, 1); pushd(esi);                             /* push esi */
            ii(0x100b_8590, 1); pushd(edi);                             /* push edi */
            ii(0x100b_8591, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_8592, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8594, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_859a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_859d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_85a0, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100b_85a7, 2); jmpd(0x100b_85af, 0x6); goto l_0x100b_85af; /* jmp 0x100b85af */
        l_0x100b_85a9:
            ii(0x100b_85a9, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_85ac, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100b_85af:
            ii(0x100b_85af, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_85b2, 5); calld(0x1008_a4a0, -0x2_e117);          /* call 0x1008a4a0 */
            ii(0x100b_85b7, 4); cmp(ax, memw_a32[ss, ebp - 0x14]);      /* cmp ax, [ebp-0x14] */
            ii(0x100b_85bb, 6); if(jled(0x100b_8652, 0x91)) goto l_0x100b_8652; /* jle 0x100b8652 */
            ii(0x100b_85c1, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100b_85c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_85c8, 5); calld(0x1008_a3dc, -0x2_e1f1);          /* call 0x1008a3dc */
            ii(0x100b_85cd, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100b_85d0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_85d3, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_85da, 2); jmpd(0x100b_85e2, 0x6); goto l_0x100b_85e2; /* jmp 0x100b85e2 */
        l_0x100b_85dc:
            ii(0x100b_85dc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_85df, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_85e2:
            ii(0x100b_85e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_85e5, 5); calld(0x1008_a4a0, -0x2_e14a);          /* call 0x1008a4a0 */
            ii(0x100b_85ea, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100b_85ee, 2); if(jled(0x100b_8605, 0x15)) goto l_0x100b_8605; /* jle 0x100b8605 */
            ii(0x100b_85f0, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_85f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_85f7, 5); calld(0x1008_a3dc, -0x2_e220);          /* call 0x1008a3dc */
            ii(0x100b_85fc, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100b_85ff, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x100b_8603, 2); if(jnzd(0x100b_85dc, -0x29)) goto l_0x100b_85dc; /* jnz 0x100b85dc */
        l_0x100b_8605:
            ii(0x100b_8605, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8608, 5); calld(0x1008_a4a0, -0x2_e16d);          /* call 0x1008a4a0 */
            ii(0x100b_860d, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x100b_8611, 2); if(jnzd(0x100b_862b, 0x18)) goto l_0x100b_862b; /* jnz 0x100b862b */
            ii(0x100b_8613, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_8615, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100b_8619, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100b_861c, 5); calld(0x100b_8462, -0x1bf);             /* call 0x100b8462 */
            ii(0x100b_8621, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_8623, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8626, 5); calld(0x1008_a41c, -0x2_e20f);          /* call 0x1008a41c */
        l_0x100b_862b:
            ii(0x100b_862b, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_862f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8632, 5); calld(0x1008_a3dc, -0x2_e25b);          /* call 0x1008a3dc */
            ii(0x100b_8637, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100b_8639, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100b_863d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_8640, 5); calld(0x1008_a3dc, -0x2_e269);          /* call 0x1008a3dc */
            ii(0x100b_8645, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100b_8649, 4); add(memw_a32[ds, ebx + 0x2], ax);       /* add [ebx+0x2], ax */
            ii(0x100b_864d, 5); jmpd(0x100b_85a9, -0xa9); goto l_0x100b_85a9; /* jmp 0x100b85a9 */
        l_0x100b_8652:
            ii(0x100b_8652, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_8655, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_8658, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_865b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_865d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_865e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_865f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8660, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8661, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8662, 1); retd(); return;                         /* ret */
        }
    }
}
