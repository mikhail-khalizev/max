using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_93e1-ac1c8da0")]
        public void Method_100b_93e1()
        {
            ii(0x100b_93e1, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100b_93e6, 5); calld(Definitions.sys_check_available_stack_size, 0xa_c967); /* call 0x10165d52 */
            ii(0x100b_93eb, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_93ec, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_93ed, 1); pushd(esi);                             /* push esi */
            ii(0x100b_93ee, 1); pushd(edi);                             /* push edi */
            ii(0x100b_93ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_93f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_93f2, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100b_93f8, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_93fb, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_93fe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9401, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100b_9405, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x100b_9409, 6); if(jzd(0x100b_9496, 0x87)) goto l_0x100b_9496; /* jz 0x100b9496 */
            ii(0x100b_940f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9412, 4); mov(ax, memw_a32[ds, eax + 0xe]);       /* mov ax, [eax+0xe] */
            ii(0x100b_9416, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x100b_9419, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_941c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_941f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_9422, 4); mov(memw_a32[ds, edx + 0xe], ax);       /* mov [edx+0xe], ax */
            ii(0x100b_9426, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x100b_942d, 2); jmpd(0x100b_9435, 0x6); goto l_0x100b_9435; /* jmp 0x100b9435 */
        l_0x100b_942f:
            ii(0x100b_942f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_9432, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x100b_9435:
            ii(0x100b_9435, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_9438, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_943b, 4); cmp(ax, memw_a32[ds, edx + 0xc]);       /* cmp ax, [edx+0xc] */
            ii(0x100b_943f, 2); if(jged(0x100b_9496, 0x55)) goto l_0x100b_9496; /* jge 0x100b9496 */
            ii(0x100b_9441, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100b_9445, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_9448, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_944b, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x100b_944e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9450, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_9452, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_9455, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100b_9459, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_945c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_945e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_9461, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x100b_9464, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9466, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100b_9468, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_946b, 6); mov(ax, memw_a32[ds, 0x101c_8174]);     /* mov ax, [0x101c8174] */
            ii(0x100b_9471, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
        l_0x100b_9474:
            ii(0x100b_9474, 3); dec(memd_a32[ss, ebp - 0x1c]);          /* dec dword [ebp-0x1c] */
            ii(0x100b_9477, 5); cmp(memw_a32[ss, ebp - 0x1c], -0x1 /* 0xff */); /* cmp word [ebp-0x1c], 0xffff */
            ii(0x100b_947c, 2); if(jzd(0x100b_9494, 0x16)) goto l_0x100b_9494; /* jz 0x100b9494 */
            ii(0x100b_947e, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100b_9481, 4); add(memd_a32[ss, ebp - 0x18], 0x2);     /* add dword [ebp-0x18], 0x2 */
            ii(0x100b_9485, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_9488, 4); imul(dx, memw_a32[ds, eax]);            /* imul dx, [eax] */
            ii(0x100b_948c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100b_948f, 3); add(memw_a32[ds, eax], dx);             /* add [eax], dx */
            ii(0x100b_9492, 2); jmpd(0x100b_9474, -0x20); goto l_0x100b_9474; /* jmp 0x100b9474 */
        l_0x100b_9494:
            ii(0x100b_9494, 2); jmpd(0x100b_942f, -0x67); goto l_0x100b_942f; /* jmp 0x100b942f */
        l_0x100b_9496:
            ii(0x100b_9496, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_9498, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_9499, 1); popd(edi);                              /* pop edi */
            ii(0x100b_949a, 1); popd(esi);                              /* pop esi */
            ii(0x100b_949b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_949c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_949d, 1); retd(); return;                         /* ret */
        }
    }
}
