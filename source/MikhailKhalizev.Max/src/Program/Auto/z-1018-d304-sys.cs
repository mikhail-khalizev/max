using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("10623476-8256-4166-af14-61bf5d8a41d6")]
        public void /* sys */ Method_1018_d304()
        {
            ii(0x1018_d304, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_d305, 1); pushd(edx);                             /* push edx */
            ii(0x1018_d306, 3); cmp(memb_a32[ds, eax], 0x2);            /* cmp byte [eax], 0x2 */
            ii(0x1018_d309, 2); if(jnzd(0x1018_d30e, 0x3)) goto l_0x1018_d30e; /* jnz 0x1018d30e */
            ii(0x1018_d30b, 3); mov(eax, memd_a32[ds, eax + 0x1]);      /* mov eax, [eax+0x1] */
        l_0x1018_d30e:
            ii(0x1018_d30e, 2); mov(bl, memb_a32[ds, eax]);             /* mov bl, [eax] */
            ii(0x1018_d310, 3); cmp(bl, 0x8);                           /* cmp bl, 0x8 */
            ii(0x1018_d313, 2); if(jad(0x1018_d33b, 0x26)) goto l_0x1018_d33b; /* ja 0x1018d33b */
            ii(0x1018_d315, 3); movzx(ebx, bl);                         /* movzx ebx, bl */
            ii(0x1018_d318, 8); 
            switch (jmpd_abs_switch(memd_a32[cs, ebx * 4 + /* sys */ 0x1018_d2e0]))
            {
                case 0x1018_d320:
                    goto l_0x1018_d320;
                case 0x1018_d329:
                    goto l_0x1018_d329;
                case 0x1018_d331:
                    goto l_0x1018_d331;
                case 0x1018_d33b:
                    goto l_0x1018_d33b;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:ebx*4+0x1018d2e0] */
        l_0x1018_d320:
            ii(0x1018_d320, 4); movzx(edx, memb_a32[ds, eax + 0x1]);    /* movzx edx, byte [eax+0x1] */
            ii(0x1018_d324, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d326, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d327, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d328, 1); retd(); return;                         /* ret */
        l_0x1018_d329:
            ii(0x1018_d329, 3); mov(edx, memd_a32[ds, eax + 0xd]);      /* mov edx, [eax+0xd] */
            ii(0x1018_d32c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d32e, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d32f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d330, 1); retd(); return;                         /* ret */
        l_0x1018_d331:
            ii(0x1018_d331, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1018_d336, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d338, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d339, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d33a, 1); retd(); return;                         /* ret */
        l_0x1018_d33b:
            ii(0x1018_d33b, 5); calld(/* sys */ 0x1019_5dab, 0x8a6b);   /* call 0x10195dab */
            ii(0x1018_d340, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_d342, 1); popd(edx);                              /* pop edx */
            ii(0x1018_d343, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_d344, 1); retd(); return;                         /* ret */
        }
    }
}
