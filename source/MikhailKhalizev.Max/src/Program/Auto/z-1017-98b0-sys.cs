using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("15c5b507-a05e-4c4c-93fe-54f16ab820ea")]
        public void /* sys */ Method_1017_98b0()
        {
            ii(0x1017_98b0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_98b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_98b3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_98b4, 1); pushd(edx);                             /* push edx */
            ii(0x1017_98b5, 5); mov(memd_a32[ds, 0x1020_9db0], eax);    /* mov [0x10209db0], eax */
            ii(0x1017_98ba, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1017_98bf, 5); calld(/* sys */ 0x1017_9970, 0xac);     /* call 0x10179970 */
            ii(0x1017_98c4, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_98c6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_98c8, 2); if(jzd(0x1017_98fc, 0x32)) goto l_0x1017_98fc; /* jz 0x101798fc */
            ii(0x1017_98ca, 5); mov(edx, StringDefinitions.InterplayMveFile); /* mov edx, 0x101b2f20 */
            ii(0x1017_98cf, 5); calld(Definitions.sys_strcmp, -0x7144); /* call 0x10172790 */
            ii(0x1017_98d4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_98d6, 2); if(jnzd(0x1017_98fc, 0x24)) goto l_0x1017_98fc; /* jnz 0x101798fc */
            ii(0x1017_98d8, 4); mov(ax, memw_a32[ds, ebx + 0x16]);      /* mov ax, [ebx+0x16] */
            ii(0x1017_98dc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_98de, 2); not(eax);                               /* not eax */
            ii(0x1017_98e0, 4); mov(dx, memw_a32[ds, ebx + 0x18]);      /* mov dx, [ebx+0x18] */
            ii(0x1017_98e4, 5); add(eax, 0x1234);                       /* add eax, 0x1234 */
            ii(0x1017_98e9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1017_98eb, 2); if(jnzd(0x1017_98fc, 0xf)) goto l_0x1017_98fc; /* jnz 0x101798fc */
            ii(0x1017_98ed, 6); cmp(memw_a32[ds, ebx + 0x16], 0x100);   /* cmp word [ebx+0x16], 0x100 */
            ii(0x1017_98f3, 2); if(jnzd(0x1017_98fc, 0x7)) goto l_0x1017_98fc; /* jnz 0x101798fc */
            ii(0x1017_98f5, 5); cmp(memw_a32[ds, ebx + 0x14], 0x1a);    /* cmp word [ebx+0x14], 0x1a */
            ii(0x1017_98fa, 2); if(jzd(0x1017_9900, 0x4)) goto l_0x1017_9900; /* jz 0x10179900 */
        l_0x1017_98fc:
            ii(0x1017_98fc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_98fe, 2); jmpd(0x1017_990d, 0xd); goto l_0x1017_990d; /* jmp 0x1017990d */
        l_0x1017_9900:
            ii(0x1017_9900, 3); mov(eax, memd_a32[ds, ebx + 0x1a]);     /* mov eax, [ebx+0x1a] */
            ii(0x1017_9903, 5); mov(memd_a32[ds, 0x1020_9db4], eax);    /* mov [0x10209db4], eax */
            ii(0x1017_9908, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
        l_0x1017_990d:
            ii(0x1017_990d, 3); lea(esp, ebp - 0x8);                    /* lea esp, [ebp-0x8] */
            ii(0x1017_9910, 1); popd(edx);                              /* pop edx */
            ii(0x1017_9911, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9912, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_9913, 1); retd(); return;                         /* ret */
        }
    }
}
