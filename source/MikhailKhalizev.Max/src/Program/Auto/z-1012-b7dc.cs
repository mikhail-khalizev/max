using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d9d9d9bd-9780-43f4-bfc6-21f55fa582af")]
        public void Method_1012_b7dc()
        {
            ii(0x1012_b7dc, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1012_b7e1, 5); calld(Definitions.sys_check_available_stack_size, 0x3_a56c); /* call 0x10165d52 */
            ii(0x1012_b7e6, 1); pushd(esi);                             /* push esi */
            ii(0x1012_b7e7, 1); pushd(edi);                             /* push edi */
            ii(0x1012_b7e8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_b7e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_b7eb, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_b7f1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_b7f4, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_b7f7, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_b7fa, 3); mov(memd_a32[ss, ebp - 0xc], ecx);      /* mov [ebp-0xc], ecx */
            ii(0x1012_b7fd, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1012_b800, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1012_b805, 1); cwde();                                 /* cwde */
            ii(0x1012_b806, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b807, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_b80a, 5); add(eax, 0x10);                         /* add eax, 0x10 */
            ii(0x1012_b80f, 1); cwde();                                 /* cwde */
            ii(0x1012_b810, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b811, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_b813, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_b818, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_b81b, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_b81f, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_b823, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b826, 5); calld(0x1012_b6af, -0x17c);             /* call 0x1012b6af */
            ii(0x1012_b82b, 5); calld(0x100d_531c, -0x5_6514);          /* call 0x100d531c */
            ii(0x1012_b830, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_b835, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b836, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_b838, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b839, 4); movsx(eax, memw_a32[ss, ebp + 0x18]);   /* movsx eax, word [ebp+0x18] */
            ii(0x1012_b83d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b83e, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1012_b843, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b844, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1012_b847, 3); sub(eax, 0x23);                         /* sub eax, 0x23 */
            ii(0x1012_b84a, 1); cwde();                                 /* cwde */
            ii(0x1012_b84b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b84c, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1012_b850, 1); pushd(eax);                             /* push eax */
            ii(0x1012_b851, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_b854, 5); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1012_b859, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1012_b85c, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_b860, 3); imul(ebx, ebx, 0x33);                   /* imul ebx, ebx, 0x33 */
            ii(0x1012_b863, 6); mov(ebx, memd_a32[ds, ebx + 0x101c_81d7]); /* mov ebx, [ebx+0x101c81d7] */
            ii(0x1012_b869, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x1012_b86d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_b870, 5); calld(0x100e_9ae5, -0x4_1d90);          /* call 0x100e9ae5 */
            ii(0x1012_b875, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_b877, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_b878, 1); popd(edi);                              /* pop edi */
            ii(0x1012_b879, 1); popd(esi);                              /* pop esi */
            ii(0x1012_b87a, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
