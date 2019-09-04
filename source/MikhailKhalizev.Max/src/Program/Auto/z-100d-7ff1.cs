using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7ff1-811bd092")]
        public void Method_100d_7ff1()
        {
            ii(0x100d_7ff1, 5); push(0x38);                             /* push 0x38 */
            ii(0x100d_7ff6, 5); call(Definitions.sys_check_available_stack_size, 0x8_dd57); /* call 0x10165d52 */
            ii(0x100d_7ffb, 1); push(ecx);                              /* push ecx */
            ii(0x100d_7ffc, 1); push(esi);                              /* push esi */
            ii(0x100d_7ffd, 1); push(edi);                              /* push edi */
            ii(0x100d_7ffe, 1); push(ebp);                              /* push ebp */
            ii(0x100d_7fff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_8001, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_8007, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100d_800a, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100d_800d, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x100d_8010, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_8013, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x100d_8016, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8019, 1); push(eax);                              /* push eax */
            ii(0x100d_801a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_801d, 3); mov(edx, memd[ds, eax + 4]);            /* mov edx, [eax+0x4] */
            ii(0x100d_8020, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_8023, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_8026, 3); add(edx, memd[ds, eax + 4]);            /* add edx, [eax+0x4] */
            ii(0x100d_8029, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_802c, 3); mov(eax, memd[ds, eax + 14]);           /* mov eax, [eax+0xe] */
            ii(0x100d_802f, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8032, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100d_8035, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x100d_8037, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_803a, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100d_803d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100d_8040, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_8043, 3); mov(eax, memd[ds, eax + 22]);           /* mov eax, [eax+0x16] */
            ii(0x100d_8046, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100d_8048, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_804b, 2); add(edx, memd[ds, eax]);                /* add edx, [eax] */
            ii(0x100d_804d, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100d_804f, 1); push(edx);                              /* push edx */
            ii(0x100d_8050, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_8053, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_8056, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_8059, 1); push(eax);                              /* push eax */
            ii(0x100d_805a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_805d, 3); mov(eax, memd[ds, eax + 12]);           /* mov eax, [eax+0xc] */
            ii(0x100d_8060, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_8063, 3); sub(eax, memd[ds, edx + 4]);            /* sub eax, [edx+0x4] */
            ii(0x100d_8066, 1); push(eax);                              /* push eax */
            ii(0x100d_8067, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_806a, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100d_806d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_8070, 2); sub(eax, memd[ds, edx]);                /* sub eax, [edx] */
            ii(0x100d_8072, 1); push(eax);                              /* push eax */
            ii(0x100d_8073, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100d_8076, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x100d_8079, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100d_807c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_807f, 4); imul(eax, memd[ds, edx + 4]);           /* imul eax, [edx+0x4] */
            ii(0x100d_8083, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100d_8086, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x100d_8088, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x100d_808b, 2); add(edx, memd[ds, ebx]);                /* add edx, [ebx] */
            ii(0x100d_808d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100d_808f, 1); push(eax);                              /* push eax */
            ii(0x100d_8090, 5); call(/* sys */ 0x1016_abbc, 0x9_2b27);  /* call 0x1016abbc */
            ii(0x100d_8095, 3); add(esp, 0x18);                         /* add esp, 0x18 */
            ii(0x100d_8098, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_809a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_809b, 1); pop(edi);                               /* pop edi */
            ii(0x100d_809c, 1); pop(esi);                               /* pop esi */
            ii(0x100d_809d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_809e, 1); ret();                                  /* ret */
        }
    }
}
