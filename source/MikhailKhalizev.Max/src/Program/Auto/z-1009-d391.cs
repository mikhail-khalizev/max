using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1e14d8b-d480-4751-a49e-4239f9dfa3b4")]
        public void Method_1009_d391()
        {
            ii(0x1009_d391, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_d396, 5); calld(Definitions.sys_check_available_stack_size, 0xc_89b7); /* call 0x10165d52 */
            ii(0x1009_d39b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_d39c, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_d39d, 1); pushd(edx);                             /* push edx */
            ii(0x1009_d39e, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d39f, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d3a0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d3a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d3a3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_d3a9, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_d3ac, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1009_d3af, 5); calld(Definitions.my_ctor_0x101b4184, -0x2_68c4); /* call 0x10076af0 */
            ii(0x1009_d3b4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_d3b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d3ba, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d3bd, 5); calld(0x1007_6574, -0x2_6e4e);          /* call 0x10076574 */
            ii(0x1009_d3c2, 5); calld(0x1015_27ed, 0xb_5426);           /* call 0x101527ed */
            ii(0x1009_d3c7, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1009_d3ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d3cd, 3); mov(eax, memd_a32[ds, eax + 0x1b]);     /* mov eax, [eax+0x1b] */
            ii(0x1009_d3d0, 5); calld(0x100a_0084, 0x2caf);             /* call 0x100a0084 */
            ii(0x1009_d3d5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_d3d7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d3da, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x1009_d3dd, 5); calld(0x1008_8b44, -0x1_489e);          /* call 0x10088b44 */
            ii(0x1009_d3e2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d3e5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d3e8, 5); calld(0x1007_6574, -0x2_6e79);          /* call 0x10076574 */
            ii(0x1009_d3ed, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1009_d3f1, 4); mov(memw_a32[ss, ebp - 0xc], ax);       /* mov [ebp-0xc], ax */
            ii(0x1009_d3f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d3f8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d3fb, 5); calld(0x1007_6574, -0x2_6e8c);          /* call 0x10076574 */
            ii(0x1009_d400, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1009_d404, 4); mov(memw_a32[ss, ebp - 0xa], ax);       /* mov [ebp-0xa], ax */
            ii(0x1009_d408, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d40b, 4); mov(ax, memw_a32[ds, eax + 0x33]);      /* mov ax, [eax+0x33] */
            ii(0x1009_d40f, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1009_d413, 2); if(jnzd(0x1009_d422, 0xd)) goto l_0x1009_d422; /* jnz 0x1009d422 */
            ii(0x1009_d415, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d418, 4); mov(ax, memw_a32[ds, eax + 0x35]);      /* mov ax, [eax+0x35] */
            ii(0x1009_d41c, 4); cmp(ax, memw_a32[ss, ebp - 0xa]);       /* cmp ax, [ebp-0xa] */
            ii(0x1009_d420, 2); if(jzd(0x1009_d424, 0x2)) goto l_0x1009_d424; /* jz 0x1009d424 */
        l_0x1009_d422:
            ii(0x1009_d422, 2); jmpd(0x1009_d42b, 0x7); goto l_0x1009_d42b; /* jmp 0x1009d42b */
        l_0x1009_d424:
            ii(0x1009_d424, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d427, 4); dec(memw_a32[ds, eax + 0x35]);          /* dec word [eax+0x35] */
        l_0x1009_d42b:
            ii(0x1009_d42b, 3); lea(edx, ebp - 0xc);                    /* lea edx, [ebp-0xc] */
            ii(0x1009_d42e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d431, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1009_d434, 5); calld(0x1008_8b44, -0x1_48f5);          /* call 0x10088b44 */
            ii(0x1009_d439, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d43c, 6); mov(memw_a32[ds, eax + 0x39], 0);       /* mov word [eax+0x39], 0x0 */
            ii(0x1009_d442, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d445, 4); mov(memb_a32[ds, eax + 0x3d], 0x1);     /* mov byte [eax+0x3d], 0x1 */
            ii(0x1009_d449, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d44c, 5); calld(0x1009_d4ae, 0x5d);               /* call 0x1009d4ae */
            ii(0x1009_d451, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d453, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d454, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d455, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d456, 1); popd(edx);                              /* pop edx */
            ii(0x1009_d457, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d458, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d459, 1); retd(); return;                         /* ret */
        }
    }
}
