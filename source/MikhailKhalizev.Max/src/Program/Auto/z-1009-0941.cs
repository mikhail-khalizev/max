using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_0941-6f7d555b")]
        public void Method_1009_0941()
        {
            ii(0x1009_0941, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_0946, 5); call(Definitions.sys_check_available_stack_size, 0xd_5407); /* call 0x10165d52 */
            ii(0x1009_094b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_094c, 1); push(esi);                              /* push esi */
            ii(0x1009_094d, 1); push(edi);                              /* push edi */
            ii(0x1009_094e, 1); push(ebp);                              /* push ebp */
            ii(0x1009_094f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0951, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_0957, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_095a, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1009_095d, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1009_0960, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0963, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_0966, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_0969, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_096b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_096e, 3); mov(edx, memd[ds, eax + 0x27]);         /* mov edx, [eax+0x27] */
            ii(0x1009_0971, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1009_0973, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0976, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_0978, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_097b, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1009_097d, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_097f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_0981, 3); mov(memd[ss, ebp - 0x14], edx);         /* mov [ebp-0x14], edx */
        l_0x1009_0984:
            ii(0x1009_0984, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_0987, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_098b, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x1009_098f, 2); if(jge(0x1009_099c, 0xb)) goto l_0x1009_099c; /* jge 0x1009099c */
            ii(0x1009_0991, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_0994, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_0997, 3); cmp(eax, 0x9);                          /* cmp eax, 0x9 */
            ii(0x1009_099a, 2); if(jz(0x1009_099e, 0x2)) goto l_0x1009_099e; /* jz 0x1009099e */
        l_0x1009_099c:
            ii(0x1009_099c, 2); jmp(0x1009_09ae, 0x10); goto l_0x1009_09ae; /* jmp 0x100909ae */
        l_0x1009_099e:
            ii(0x1009_099e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_09a1, 4); add(memd[ss, ebp - 0x14], 0x2);         /* add dword [ebp-0x14], 0x2 */
            ii(0x1009_09a5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_09a8, 4); inc(memw[ds, eax + 0x2]);               /* inc word [eax+0x2] */
            ii(0x1009_09ac, 2); jmp(0x1009_0984, -0x2a); goto l_0x1009_0984; /* jmp 0x10090984 */
        l_0x1009_09ae:
            ii(0x1009_09ae, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_09b1, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x1009_09b5, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_09b8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_09bb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_09bd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_09be, 1); pop(edi);                               /* pop edi */
            ii(0x1009_09bf, 1); pop(esi);                               /* pop esi */
            ii(0x1009_09c0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_09c1, 1); ret();                                  /* ret */
        }
    }
}
