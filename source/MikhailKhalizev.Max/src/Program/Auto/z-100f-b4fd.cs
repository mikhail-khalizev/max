using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("03ba50fd-126d-4209-a900-9ce0775e80d0")]
        public void Method_100f_b4fd()
        {
            ii(0x100f_b4fd, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100f_b502, 5); calld(Definitions.sys_check_available_stack_size, 0x6a84b); /* call 0x10165d52 */
            ii(0x100f_b507, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_b508, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_b509, 1); pushd(esi);                             /* push esi */
            ii(0x100f_b50a, 1); pushd(edi);                             /* push edi */
            ii(0x100f_b50b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_b50c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_b50e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100f_b514, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_b517, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100f_b51a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_b51d, 6); mov(memw_a32[ds, 0x101c_3962], ax);     /* mov [0x101c3962], ax */
            ii(0x100f_b523, 8); cmp(memw_a32[ds, 0x101c_3962], 0);      /* cmp word [0x101c3962], 0x0 */
            ii(0x100f_b52b, 2); if(jzd(0x100f_b54a, 0x1d)) goto l_0x100f_b54a; /* jz 0x100fb54a */
            ii(0x100f_b52d, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100f_b530, 5); mov(memb_a32[ds, 0x101c_3970], al);     /* mov [0x101c3970], al */
            ii(0x100f_b535, 7); cmp(memb_a32[ds, 0x101c_3970], 0);      /* cmp byte [0x101c3970], 0x0 */
            ii(0x100f_b53c, 2); if(jzd(0x100f_b548, 0xa)) goto l_0x100f_b548; /* jz 0x100fb548 */
            ii(0x100f_b53e, 5); calld(0x1014_82f4, 0x4cdb1);            /* call 0x101482f4 */
            ii(0x100f_b543, 5); mov(memd_a32[ds, 0x101c_396c], eax);    /* mov [0x101c396c], eax */
        l_0x100f_b548:
            ii(0x100f_b548, 2); jmpd(0x100f_b551, 0x7); goto l_0x100f_b551; /* jmp 0x100fb551 */
        l_0x100f_b54a:
            ii(0x100f_b54a, 7); mov(memb_a32[ds, 0x101c_3970], 0);      /* mov byte [0x101c3970], 0x0 */
        l_0x100f_b551:
            ii(0x100f_b551, 5); calld(0x1010_2aac, 0x7556);             /* call 0x10102aac */
            ii(0x100f_b556, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_b558, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_b55a, 5); mov(eax, memd_a32[ds, 0x101c_3960]);    /* mov eax, [0x101c3960] */
            ii(0x100f_b55f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_b562, 5); calld(0x100f_334b, -0x821c);            /* call 0x100f334b */
            ii(0x100f_b567, 7); mov(memb_a32[ds, 0x101c_37d2], 0);      /* mov byte [0x101c37d2], 0x0 */
            ii(0x100f_b56e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_b570, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_b571, 1); popd(edi);                              /* pop edi */
            ii(0x100f_b572, 1); popd(esi);                              /* pop esi */
            ii(0x100f_b573, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_b574, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_b575, 1); retd(); return;                         /* ret */
        }
    }
}