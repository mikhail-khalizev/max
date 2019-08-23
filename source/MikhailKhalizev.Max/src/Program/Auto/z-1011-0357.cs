using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_0357-fc08d4fc")]
        public void Method_1011_0357()
        {
            ii(0x1011_0357, 5); push(0x38);                             /* push 0x38 */
            ii(0x1011_035c, 5); call(Definitions.sys_check_available_stack_size, 0x5_59f1); /* call 0x10165d52 */
            ii(0x1011_0361, 1); push(ebx);                              /* push ebx */
            ii(0x1011_0362, 1); push(ecx);                              /* push ecx */
            ii(0x1011_0363, 1); push(edx);                              /* push edx */
            ii(0x1011_0364, 1); push(esi);                              /* push esi */
            ii(0x1011_0365, 1); push(edi);                              /* push edi */
            ii(0x1011_0366, 1); push(ebp);                              /* push ebp */
            ii(0x1011_0367, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_0369, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_036f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_0372, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0375, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_0377, 5); call(0x1010_eda6, -0x15d6);             /* call 0x1010eda6 */
            ii(0x1011_037c, 7); mov(memd[ss, ebp - 0x14], 0x101b_ad80); /* mov dword [ebp-0x14], 0x101bad80 */
            ii(0x1011_0383, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_0386, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x1011_038a, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_038d, 3); sub(ax, memw[ds, edx]);                 /* sub ax, [edx] */
            ii(0x1011_0390, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_0393, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_0396, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1011_0398, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1011_039b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_039e, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_03a1, 3); mov(ebx, memd[ds, edx + 0x4]);          /* mov ebx, [edx+0x4] */
            ii(0x1011_03a4, 3); imul(ebx, eax);                         /* imul ebx, eax */
            ii(0x1011_03a7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_03aa, 2); mov(eax, memd[ds, edx]);                /* mov eax, [edx] */
            ii(0x1011_03ac, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_03af, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_03b2, 2); add(eax, memd[ds, edx]);                /* add eax, [edx] */
            ii(0x1011_03b4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1011_03b6, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_03b9, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_03bc, 7); mov(ax, memw[ds, eax + 0x14a]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_03c3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_03c6, 7); add(ax, memw[ds, edx + 0x14c]);         /* add ax, [edx+0x14c] */
            ii(0x1011_03cd, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_03d0, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_03d3, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_03d6, 7); cmp(ax, memw[ds, edx + 0x148]);         /* cmp ax, [edx+0x148] */
            ii(0x1011_03dd, 2); if(jle(0x1011_03ec, 0xd)) goto l_0x1011_03ec; /* jle 0x101103ec */
            ii(0x1011_03df, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_03e2, 7); mov(ax, memw[ds, eax + 0x148]);         /* mov ax, [eax+0x148] */
            ii(0x1011_03e9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1011_03ec:
            ii(0x1011_03ec, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_03ef, 7); cmp(memd[ds, eax + 0x144], 0);          /* cmp dword [eax+0x144], 0x0 */
            ii(0x1011_03f6, 6); if(jz(0x1011_047d, 0x81)) goto l_0x1011_047d; /* jz 0x1011047d */
            ii(0x1011_03fc, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_03ff, 7); mov(ax, memw[ds, eax + 0x14a]);         /* mov ax, [eax+0x14a] */
            ii(0x1011_0406, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1011_0409, 2); jmp(0x1011_0411, 0x6); goto l_0x1011_0411; /* jmp 0x10110411 */
        l_0x1011_040b:
            ii(0x1011_040b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_040e, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x1011_0411:
            ii(0x1011_0411, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_0414, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x1011_0418, 2); if(jge(0x1011_047d, 0x63)) goto l_0x1011_047d; /* jge 0x1011047d */
            ii(0x1011_041a, 5); push(0xa2);                             /* push 0xa2 */
            ii(0x1011_041f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0422, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_0424, 3); mov(ecx, memd[ds, eax + 0xe]);          /* mov ecx, [eax+0xe] */
            ii(0x1011_0427, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1011_042a, 4); movsx(ebx, memw[ss, ebp - 0x8]);        /* movsx ebx, word [ebp-0x8] */
            ii(0x1011_042e, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_0432, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1011_0435, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0438, 6); mov(eax, memd[ds, eax + 0x144]);        /* mov eax, [eax+0x144] */
            ii(0x1011_043e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1011_0440, 5); call(Definitions.my_strobj_c_str_v2, -0x8_6c7d); /* call 0x100897c8 */
            ii(0x1011_0445, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_0447, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_044a, 6); mov(esi, memd[ds, eax + 0x148]);        /* mov esi, [eax+0x148] */
            ii(0x1011_0450, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1011_0453, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_0457, 2); sub(eax, esi);                          /* sub eax, esi */
            ii(0x1011_0459, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1011_045b, 6); call_abs(memd[ds, 0x101b_ddf0]);        /* call dword [0x101bddf0] */
            ii(0x1011_0461, 3); imul(esi, eax);                         /* imul esi, eax */
            ii(0x1011_0464, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0467, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_0469, 3); mov(eax, memd[ds, eax + 0xe]);          /* mov eax, [eax+0xe] */
            ii(0x1011_046c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_046f, 3); imul(eax, esi);                         /* imul eax, esi */
            ii(0x1011_0472, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1011_0475, 6); call_abs(memd[ds, 0x101b_ddec]);        /* call dword [0x101bddec] */
            ii(0x1011_047b, 2); jmp(0x1011_040b, -0x72); goto l_0x1011_040b; /* jmp 0x1011040b */
        l_0x1011_047d:
            ii(0x1011_047d, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_0480, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_0483, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_0485, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1011_0488, 5); call(Definitions.sys_display_draw_1, 0x5_701b); /* call 0x101674a8 */
            ii(0x1011_048d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_048f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_0490, 1); pop(edi);                               /* pop edi */
            ii(0x1011_0491, 1); pop(esi);                               /* pop esi */
            ii(0x1011_0492, 1); pop(edx);                               /* pop edx */
            ii(0x1011_0493, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_0494, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_0495, 1); ret();                                  /* ret */
        }
    }
}
