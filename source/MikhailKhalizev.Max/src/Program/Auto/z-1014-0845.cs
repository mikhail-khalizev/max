using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_0845-aaab667")]
        public void Method_1014_0845()
        {
            ii(0x1014_0845, 5); push(0xa8);                             /* push 0xa8 */
            ii(0x1014_084a, 5); call(Definitions.sys_check_available_stack_size, 0x2_5503); /* call 0x10165d52 */
            ii(0x1014_084f, 1); push(esi);                              /* push esi */
            ii(0x1014_0850, 1); push(edi);                              /* push edi */
            ii(0x1014_0851, 1); push(ebp);                              /* push ebp */
            ii(0x1014_0852, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_0854, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x1014_085a, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_085d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_0860, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1014_0863, 3); mov(memd[ss, ebp - 0xc], ecx);          /* mov [ebp-0xc], ecx */
            ii(0x1014_0866, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_0869, 6); call_abs(memd[ds, 0x101b_ddf4]);        /* call dword [0x101bddf4] */
            ii(0x1014_086f, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_0872, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1014_0876, 1); push(eax);                              /* push eax */
            ii(0x1014_0877, 3); mov(ecx, memd[ss, ebp - 0x10]);         /* mov ecx, [ebp-0x10] */
            ii(0x1014_087a, 3); mov(ecx, memd[ds, ecx + 0xe]);          /* mov ecx, [ecx+0xe] */
            ii(0x1014_087d, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1014_0880, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_0883, 3); mov(eax, memd[ds, edx + 0x2c]);         /* mov eax, [edx+0x2c] */
            ii(0x1014_0886, 5); call(0x100d_4f58, -0x6_b933);           /* call 0x100d4f58 */
            ii(0x1014_088b, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_088e, 3); mov(esi, memd[ss, ebp - 0x8]);          /* mov esi, [ebp-0x8] */
            ii(0x1014_0891, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_0897, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_0899, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1014_089b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1014_089e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1014_08a0, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1014_08a2, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1014_08a6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_08a8, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1014_08ab, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_08ae, 3); mov(eax, memd[ds, edx + 0xe]);          /* mov eax, [edx+0xe] */
            ii(0x1014_08b1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_08b4, 4); imul(eax, memd[ss, ebp - 0x18]);        /* imul eax, [ebp-0x18] */
            ii(0x1014_08b8, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1014_08bb, 3); mov(edx, memd[ds, edx + 0x16]);         /* mov edx, [edx+0x16] */
            ii(0x1014_08be, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1014_08c0, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1014_08c2, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1014_08c8, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1014_08cc, 2); if(jnz(0x1014_08ee, 0x20)) goto l_0x1014_08ee; /* jnz 0x101408ee */
            ii(0x1014_08ce, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1014_08d3, 5); call(0x100c_b5c8, -0x7_5310);           /* call 0x100cb5c8 */
            ii(0x1014_08d8, 1); cwde();                                 /* cwde */
            ii(0x1014_08d9, 1); push(eax);                              /* push eax */
            ii(0x1014_08da, 5); mov(eax, StringDefinitions.TaskManagerIRemindersQueued); /* mov eax, 0x101ace0e */
            ii(0x1014_08df, 1); push(eax);                              /* push eax */
            ii(0x1014_08e0, 3); lea(eax, memd[ss, ebp - 0x7c]);         /* lea eax, [ebp-0x7c] */
            ii(0x1014_08e3, 1); push(eax);                              /* push eax */
            ii(0x1014_08e4, 5); call(Definitions.sys_sprintf, 0x2_5618); /* call 0x10165f01 */
            ii(0x1014_08e9, 3); add(esp, 0xc);                          /* add esp, 0xc */
            ii(0x1014_08ec, 2); jmp(0x1014_0903, 0x15); goto l_0x1014_0903; /* jmp 0x10140903 */
        l_0x1014_08ee:
            ii(0x1014_08ee, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_08f1, 3); mov(memd[ss, ebp - 0x80], eax);         /* mov [ebp-0x80], eax */
            ii(0x1014_08f4, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1014_08f7, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1014_08fa, 3); lea(edx, memd[ss, ebp - 0x7c]);         /* lea edx, [ebp-0x7c] */
            ii(0x1014_08fd, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x1014_0900, 3); call_abs(memd[ds, ebx + 0x18]);         /* call dword [ebx+0x18] */
        l_0x1014_0903:
            ii(0x1014_0903, 5); call(0x100d_531c, -0x6_b5ec);           /* call 0x100d531c */
            ii(0x1014_0908, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_090d, 1); push(eax);                              /* push eax */
            ii(0x1014_090e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1014_0910, 1); push(eax);                              /* push eax */
            ii(0x1014_0911, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1014_0915, 1); push(eax);                              /* push eax */
            ii(0x1014_0916, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1014_091c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1014_091e, 1); cwde();                                 /* cwde */
            ii(0x1014_091f, 1); push(eax);                              /* push eax */
            ii(0x1014_0920, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0923, 3); mov(eax, memd[ds, eax + 0x2c]);         /* mov eax, [eax+0x2c] */
            ii(0x1014_0926, 5); call(0x100d_4f58, -0x6_b9d3);           /* call 0x100d4f58 */
            ii(0x1014_092b, 3); sub(eax, memd[ss, ebp - 0x14]);         /* sub eax, [ebp-0x14] */
            ii(0x1014_092e, 1); cwde();                                 /* cwde */
            ii(0x1014_092f, 1); push(eax);                              /* push eax */
            ii(0x1014_0930, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1014_0934, 1); push(eax);                              /* push eax */
            ii(0x1014_0935, 4); movsx(ecx, memw[ss, ebp - 0x14]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1014_0939, 3); lea(ebx, memd[ss, ebp - 0x7c]);         /* lea ebx, [ebp-0x7c] */
            ii(0x1014_093c, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_093f, 3); mov(edx, memd[ds, eax + 0xe]);          /* mov edx, [eax+0xe] */
            ii(0x1014_0942, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_0945, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_0948, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1014_094b, 5); call(0x100e_9ae5, -0x5_6e6b);           /* call 0x100e9ae5 */
            ii(0x1014_0950, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_0952, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_0953, 1); pop(edi);                               /* pop edi */
            ii(0x1014_0954, 1); pop(esi);                               /* pop esi */
            ii(0x1014_0955, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
