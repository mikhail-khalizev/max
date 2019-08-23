using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_5fba-b989c0ed")]
        public void Method_1012_5fba()
        {
            ii(0x1012_5fba, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_5fbf, 5); calld(Definitions.sys_check_available_stack_size, 0x3_fd8e); /* call 0x10165d52 */
            ii(0x1012_5fc4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_5fc5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_5fc6, 1); pushd(esi);                             /* push esi */
            ii(0x1012_5fc7, 1); pushd(edi);                             /* push edi */
            ii(0x1012_5fc8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_5fc9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_5fcb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_5fd1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_5fd4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_5fd7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_5fda, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_5fdd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_5fe0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5fe3, 5); calld(0x1012_5ebb, -0x12d);             /* call 0x10125ebb */
            ii(0x1012_5fe8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5feb, 4); mov(dx, memw_a32[ds, eax + 0x7]);       /* mov dx, [eax+0x7] */
            ii(0x1012_5fef, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_5ff2, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x1012_5ff6, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_5ff9, 4); mov(dx, memw_a32[ds, eax + 0x9]);       /* mov dx, [eax+0x9] */
            ii(0x1012_5ffd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6000, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x1012_6004, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6007, 3); mov(eax, memd_a32[ds, eax + 0x9]);      /* mov eax, [eax+0x9] */
            ii(0x1012_600a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_600d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_600f, 2); if(jnzd(0x1012_601d, 0xc)) goto l_0x1012_601d; /* jnz 0x1012601d */
            ii(0x1012_6011, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6013, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6016, 5); calld(0x1007_60ac, -0xa_ff6f);          /* call 0x100760ac */
            ii(0x1012_601b, 2); jmpd(0x1012_603a, 0x1d); goto l_0x1012_603a; /* jmp 0x1012603a */
        l_0x1012_601d:
            ii(0x1012_601d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_6020, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_6022, 4); mov(dx, memw_a32[ds, eax + 0xb]);       /* mov dx, [eax+0xb] */
            ii(0x1012_6026, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1012_602b, 5); calld(0x1010_3eba, -0x2_2176);          /* call 0x10103eba */
            ii(0x1012_6030, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_6032, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_6035, 5); calld(0x1007_60ac, -0xa_ff8e);          /* call 0x100760ac */
        l_0x1012_603a:
            ii(0x1012_603a, 7); mov(memd_a32[ss, ebp - 0xc], 0xd);      /* mov dword [ebp-0xc], 0xd */
            ii(0x1012_6041, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_6044, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_6046, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_6047, 1); popd(edi);                              /* pop edi */
            ii(0x1012_6048, 1); popd(esi);                              /* pop esi */
            ii(0x1012_6049, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_604a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_604b, 1); retd();                                 /* ret */
        }
    }
}
