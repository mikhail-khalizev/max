using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c1f5393-6179-47a2-9531-d7b8f1bd0663")]
        public void /* sys */ Method_1018_c6f0()
        {
            ii(0x1018_c6f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_c6f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_c6f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_c6f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_c6f5, 1); pushd(edx);                             /* push edx */
            ii(0x1018_c6f6, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1018_c6f9, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_c6fb, 5); calld(/* sys */ 0x1018_c450, -0x2b0);   /* call 0x1018c450 */
            ii(0x1018_c700, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c702, 2); if(jzd(0x1018_c755, 0x51)) goto l_0x1018_c755; /* jz 0x1018c755 */
            ii(0x1018_c704, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1018_c707, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_c70c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_c70e, 5); calld(Definitions.sys_memset, -0x26933); /* call 0x10165de0 */
            ii(0x1018_c713, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_c715, 2); mov(dl, 0x2);                           /* mov dl, 0x2 */
            ii(0x1018_c717, 3); mov(memb_a32[ss, ebp - 0x23], ah);      /* mov [ebp-0x23], ah */
            ii(0x1018_c71a, 3); mov(memb_a32[ss, ebp - 0x24], dl);      /* mov [ebp-0x24], dl */
            ii(0x1018_c71d, 6); mov(ax, memw_a32[ds, 0x1020_b708]);     /* mov ax, [0x1020b708] */
            ii(0x1018_c723, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_c728, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x1018_c72c, 4); mov(memw_a32[ss, ebp - 0x12], dx);      /* mov [ebp-0x12], dx */
            ii(0x1018_c730, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_c735, 3); lea(edx, ebp - 0x40);                   /* lea edx, [ebp-0x40] */
            ii(0x1018_c738, 4); mov(memw_a32[ss, ebp - 0x30], cx);      /* mov [ebp-0x30], cx */
            ii(0x1018_c73c, 5); calld(/* sys */ 0x1019_4540, 0x7dff);   /* call 0x10194540 */
            ii(0x1018_c741, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c743, 2); if(jzd(0x1018_c74c, 0x7)) goto l_0x1018_c74c; /* jz 0x1018c74c */
            ii(0x1018_c745, 5); cmp(memw_a32[ss, ebp - 0x24], 0x4f);    /* cmp word [ebp-0x24], 0x4f */
            ii(0x1018_c74a, 2); if(jzd(0x1018_c750, 0x4)) goto l_0x1018_c750; /* jz 0x1018c750 */
        l_0x1018_c74c:
            ii(0x1018_c74c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c74e, 2); jmpd(0x1018_c755, 0x5); goto l_0x1018_c755; /* jmp 0x1018c755 */
        l_0x1018_c750:
            ii(0x1018_c750, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1018_c755:
            ii(0x1018_c755, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1018_c758, 1); popd(edx);                              /* pop edx */
            ii(0x1018_c759, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_c75a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_c75b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_c75c, 1); retd(); return;                         /* ret */
        }
    }
}
