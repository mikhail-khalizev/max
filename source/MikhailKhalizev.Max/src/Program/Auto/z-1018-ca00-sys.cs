using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("591016d4-7afe-474f-aed0-266f294a2425")]
        public void /* sys */ Method_1018_ca00()
        {
            ii(0x1018_ca00, 1); pushd(ebp);                             /* push ebp */
            ii(0x1018_ca01, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_ca03, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1018_ca06, 5); calld(/* sys */ 0x1018_c450, -0x5bb);   /* call 0x1018c450 */
            ii(0x1018_ca0b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_ca0d, 2); if(jzd(0x1018_ca74, 0x65)) goto l_0x1018_ca74; /* jz 0x1018ca74 */
            ii(0x1018_ca0f, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1018_ca12, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_ca17, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_ca19, 5); calld(Definitions.sys_memset, -0x2_6c3e); /* call 0x10165de0 */
            ii(0x1018_ca1e, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_ca20, 2); mov(dl, 0x5);                           /* mov dl, 0x5 */
            ii(0x1018_ca22, 3); mov(memb_a32[ss, ebp - 0x17], ah);      /* mov [ebp-0x17], ah */
            ii(0x1018_ca25, 3); mov(memb_a32[ss, ebp - 0x18], dl);      /* mov [ebp-0x18], dl */
            ii(0x1018_ca28, 6); mov(ax, memw_a32[ds, 0x1020_b708]);     /* mov ax, [0x1020b708] */
            ii(0x1018_ca2e, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_ca33, 4); mov(memw_a32[ss, ebp - 0x4], ax);       /* mov [ebp-0x4], ax */
            ii(0x1018_ca37, 4); mov(memw_a32[ss, ebp - 0x6], dx);       /* mov [ebp-0x6], dx */
            ii(0x1018_ca3b, 2); mov(dh, 0x1);                           /* mov dh, 0x1 */
            ii(0x1018_ca3d, 3); mov(al, memb_a32[ss, ebp + 0x8]);       /* mov al, [ebp+0x8] */
            ii(0x1018_ca40, 3); mov(memb_a32[ss, ebp - 0x23], dh);      /* mov [ebp-0x23], dh */
            ii(0x1018_ca43, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1018_ca46, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_ca4b, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1018_ca4e, 5); calld(/* sys */ 0x1019_4540, 0x7aed);   /* call 0x10194540 */
            ii(0x1018_ca53, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_ca55, 2); if(jzd(0x1018_ca5e, 0x7)) goto l_0x1018_ca5e; /* jz 0x1018ca5e */
            ii(0x1018_ca57, 5); cmp(memw_a32[ss, ebp - 0x18], 0x4f);    /* cmp word [ebp-0x18], 0x4f */
            ii(0x1018_ca5c, 2); if(jzd(0x1018_ca64, 0x6)) goto l_0x1018_ca64; /* jz 0x1018ca64 */
        l_0x1018_ca5e:
            ii(0x1018_ca5e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_ca60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_ca62, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_ca63, 1); retd(); return;                         /* ret */
        l_0x1018_ca64:
            ii(0x1018_ca64, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_ca66, 3); mov(edx, memd_a32[ss, ebp + 0xc]);      /* mov edx, [ebp+0xc] */
            ii(0x1018_ca69, 4); mov(ax, memw_a32[ss, ebp - 0x20]);      /* mov ax, [ebp-0x20] */
            ii(0x1018_ca6d, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1018_ca6f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1018_ca74:
            ii(0x1018_ca74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1018_ca76, 1); popd(ebp);                              /* pop ebp */
            ii(0x1018_ca77, 1); retd(); return;                         /* ret */
        }
    }
}
