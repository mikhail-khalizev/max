using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_002d-5e54043a")]
        public void Method_1014_002d()
        {
            ii(0x1014_002d, 5); push(0x30);                             /* push 0x30 */
            ii(0x1014_0032, 5); call(Definitions.sys_check_available_stack_size, 0x2_5d1b); /* call 0x10165d52 */
            ii(0x1014_0037, 1); push(esi);                              /* push esi */
            ii(0x1014_0038, 1); push(edi);                              /* push edi */
            ii(0x1014_0039, 1); push(ebp);                              /* push ebp */
            ii(0x1014_003a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_003c, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_0042, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_0045, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_0048, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1014_004b, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1014_004e, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1014_0053, 1); push(eax);                              /* push eax */
            ii(0x1014_0054, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_0057, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1014_005a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_005d, 1); push(eax);                              /* push eax */
            ii(0x1014_005e, 4); movsx(ecx, memw[ss, ebp + 0x10]);       /* movsx ecx, word [ebp+0x10] */
            ii(0x1014_0062, 5); mov(ebx, StringDefinitions.Speed2);     /* mov ebx, 0x101ace03 */
            ii(0x1014_0067, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_006b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_006e, 5); call(0x1013_f4b0, -0xbc3);              /* call 0x1013f4b0 */
            ii(0x1014_0073, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_0076, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1014_0079, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_007c, 1); push(eax);                              /* push eax */
            ii(0x1014_007d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_0080, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1014_0083, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_0086, 1); push(eax);                              /* push eax */
            ii(0x1014_0087, 5); mov(eax, 0x26e);                        /* mov eax, 0x26e */
            ii(0x1014_008c, 1); push(eax);                              /* push eax */
            ii(0x1014_008d, 5); mov(ecx, 0x26e);                        /* mov ecx, 0x26e */
            ii(0x1014_0092, 3); mov(eax, memd[ss, ebp + 0x10]);         /* mov eax, [ebp+0x10] */
            ii(0x1014_0095, 3); sub(eax, 0x4c);                         /* sub eax, 0x4c */
            ii(0x1014_0098, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_009b, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_009f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_00a2, 3); add(eax, 0x4c);                         /* add eax, 0x4c */
            ii(0x1014_00a5, 5); call(0x1013_f629, -0xa81);              /* call 0x1013f629 */
            ii(0x1014_00aa, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1014_00ae, 3); imul(eax, eax, 0x13);                   /* imul eax, eax, 0x13 */
            ii(0x1014_00b1, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_00b4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_00b6, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
            ii(0x1014_00b9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1014_00bc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_00be, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_00bf, 1); pop(edi);                               /* pop edi */
            ii(0x1014_00c0, 1); pop(esi);                               /* pop esi */
            ii(0x1014_00c1, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
