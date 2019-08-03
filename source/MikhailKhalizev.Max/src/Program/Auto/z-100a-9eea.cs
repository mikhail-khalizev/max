using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1accbaf-986b-4d79-a4b7-b703be4946a2")]
        public void Method_100a_9eea()
        {
            ii(0x100a_9eea, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_9eef, 5); calld(Definitions.sys_check_available_stack_size, 0xbbe5e); /* call 0x10165d52 */
            ii(0x100a_9ef4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_9ef5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_9ef6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_9ef7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_9ef8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_9ef9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9efb, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_9f01, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_9f04, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_9f07, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100a_9f0a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_9f0d, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_9f10, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x100a_9f12, 1); cwde();                                 /* cwde */
            ii(0x100a_9f13, 5); calld(0x1007_8137, -0x31de1);           /* call 0x10078137 */
            ii(0x100a_9f18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_9f1b, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x100a_9f1e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_9f23, 4); mov(al, memb_a32[ds, eax + ebp - 0x14]); /* mov al, [eax+ebp-0x14] */
            ii(0x100a_9f27, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100a_9f2a, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100a_9f2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9f2f, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_9f30, 1); popd(edi);                              /* pop edi */
            ii(0x100a_9f31, 1); popd(esi);                              /* pop esi */
            ii(0x100a_9f32, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9f33, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_9f34, 1); retd(); return;                         /* ret */
        }
    }
}
