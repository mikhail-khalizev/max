using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b7cbd04-bf92-4d8c-ad48-a3875ac2f1ea")]
        public void Method_100a_95c1()
        {
            ii(0x100a_95c1, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_95c6, 5); calld(Definitions.sys_check_available_stack_size, 0xb_c787); /* call 0x10165d52 */
            ii(0x100a_95cb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_95cc, 1); pushd(esi);                             /* push esi */
            ii(0x100a_95cd, 1); pushd(edi);                             /* push edi */
            ii(0x100a_95ce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_95cf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_95d1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_95d7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_95da, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100a_95dd, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x100a_95e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_95e3, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2af8); /* call 0x10076af0 */
            ii(0x100a_95e8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_95eb, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_95ee, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100a_95f1, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2b06); /* call 0x10076af0 */
            ii(0x100a_95f6, 3); sub(eax, 0x8);                          /* sub eax, 0x8 */
            ii(0x100a_95f9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_95fc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_95ff, 3); add(eax, 0xc);                          /* add eax, 0xc */
            ii(0x100a_9602, 5); calld(Definitions.my_ctor_0x101b_4184, -0x3_2b17); /* call 0x10076af0 */
            ii(0x100a_9607, 3); sub(eax, 0xc);                          /* sub eax, 0xc */
            ii(0x100a_960a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_960d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9610, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_9613, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100a_9617, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_961a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_961d, 5); calld(0x1008_8b44, -0x2_0ade);          /* call 0x10088b44 */
            ii(0x100a_9622, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9625, 4); mov(dx, memw_a32[ds, eax + 0x4]);       /* mov dx, [eax+0x4] */
            ii(0x100a_9629, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_962c, 3); imul(edx, edx);                         /* imul edx, edx */
            ii(0x100a_962f, 4); mov(memw_a32[ds, eax + 0x6], dx);       /* mov [eax+0x6], dx */
            ii(0x100a_9633, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9636, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100a_963a, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_963d, 4); add(ax, memw_a32[ds, edx + 0x4]);       /* add ax, [edx+0x4] */
            ii(0x100a_9641, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_9644, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100a_9648, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_964b, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x100a_964e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_9651, 5); mov(eax, memd_a32[ds, 0x101c_8172]);    /* mov eax, [0x101c8172] */
            ii(0x100a_9656, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_9659, 1); dec(eax);                               /* dec eax */
            ii(0x100a_965a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_965c, 2); if(jled(0x100a_966c, 0xe)) goto l_0x100a_966c; /* jle 0x100a966c */
            ii(0x100a_965e, 6); mov(ax, memw_a32[ds, 0x101c_8174]);     /* mov ax, [0x101c8174] */
            ii(0x100a_9664, 1); dec(eax);                               /* dec eax */
            ii(0x100a_9665, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100a_9668, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
        l_0x100a_966c:
            ii(0x100a_966c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_966f, 5); calld(0x100a_9684, 0x10);               /* call 0x100a9684 */
            ii(0x100a_9674, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9677, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_967a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_967d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_967f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_9680, 1); popd(edi);                              /* pop edi */
            ii(0x100a_9681, 1); popd(esi);                              /* pop esi */
            ii(0x100a_9682, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9683, 1); retd(); return;                         /* ret */
        }
    }
}
