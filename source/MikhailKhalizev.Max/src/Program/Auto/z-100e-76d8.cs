using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_76d8-9b21964")]
        public void Method_100e_76d8()
        {
            ii(0x100e_76d8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_76dd, 5); calld(Definitions.sys_check_available_stack_size, 0x7_e670); /* call 0x10165d52 */
            ii(0x100e_76e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_76e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_76e4, 1); pushd(esi);                             /* push esi */
            ii(0x100e_76e5, 1); pushd(edi);                             /* push edi */
            ii(0x100e_76e6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_76e7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_76e9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_76ef, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_76f2, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100e_76f5, 3); mov(edx, memd_a32[ss, ebp + 0x18]);     /* mov edx, [ebp+0x18] */
            ii(0x100e_76f8, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_76fb, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_76fd, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7700, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7706, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_770c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_770f, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7711, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_7714, 3); mov(edx, memd_a32[ss, ebp + 0x1c]);     /* mov edx, [ebp+0x1c] */
            ii(0x100e_7717, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_771a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_771c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_771f, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7725, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_772b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_772e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7730, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_7733, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100e_7737, 6); imul(eax, eax, 0x280);                  /* imul eax, eax, 0x280 */
            ii(0x100e_773d, 3); mov(edx, memd_a32[ss, ebp + 0x28]);     /* mov edx, [ebp+0x28] */
            ii(0x100e_7740, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_7742, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_7746, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_7748, 6); mov(memd_a32[ds, 0x101c_9474], edx);    /* mov [0x101c9474], edx */
            ii(0x100e_774e, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100e_7753, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_7756, 4); imul(eax, memd_a32[ss, ebp - 0x8]);     /* imul eax, [ebp-0x8] */
            ii(0x100e_775a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_775d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100e_775f, 6); mov(memd_a32[ds, 0x101c_9470], edx);    /* mov [0x101c9470], edx */
            ii(0x100e_7765, 7); cmp(memb_a32[ds, 0x101c_814a], 0);      /* cmp byte [0x101c814a], 0x0 */
            ii(0x100e_776c, 2); if(jzd(0x100e_7782, 0x14)) goto l_0x100e_7782; /* jz 0x100e7782 */
            ii(0x100e_776e, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x100e_7773, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100e_7778, 3); lea(eax, ebp + 0x18);                   /* lea eax, [ebp+0x18] */
            ii(0x100e_777b, 5); calld(0x100e_f4cd, 0x7d4d);             /* call 0x100ef4cd */
            ii(0x100e_7780, 2); jmpd(0x100e_7794, 0x12); goto l_0x100e_7794; /* jmp 0x100e7794 */
        l_0x100e_7782:
            ii(0x100e_7782, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x100e_7787, 5); mov(edx, 0x40);                         /* mov edx, 0x40 */
            ii(0x100e_778c, 3); lea(eax, ebp + 0x18);                   /* lea eax, [ebp+0x18] */
            ii(0x100e_778f, 5); calld(0x100e_f4cd, 0x7d39);             /* call 0x100ef4cd */
        l_0x100e_7794:
            ii(0x100e_7794, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7796, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7797, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7798, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7799, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_779a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_779b, 3); retd(0x14);                             /* ret 0x14 */
        }
    }
}
