using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_91b9-3ee64b9a")]
        public void Method_100b_91b9()
        {
            ii(0x100b_91b9, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_91be, 5); call(Definitions.sys_check_available_stack_size, 0xa_cb8f); /* call 0x10165d52 */
            ii(0x100b_91c3, 1); push(ebx);                              /* push ebx */
            ii(0x100b_91c4, 1); push(ecx);                              /* push ecx */
            ii(0x100b_91c5, 1); push(edx);                              /* push edx */
            ii(0x100b_91c6, 1); push(esi);                              /* push esi */
            ii(0x100b_91c7, 1); push(edi);                              /* push edi */
            ii(0x100b_91c8, 1); push(ebp);                              /* push ebp */
            ii(0x100b_91c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_91cb, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_91d1, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_91d4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_91d7, 4); mov(memb[ds, eax + 16], 0);             /* mov byte [eax+0x10], 0x0 */
            ii(0x100b_91db, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_91de, 4); cmp(memd[ds, eax + 4], 0);              /* cmp dword [eax+0x4], 0x0 */
            ii(0x100b_91e2, 6); if(jz(0x100b_9268, 0x80)) goto l_0x100b_9268; /* jz 0x100b9268 */
            ii(0x100b_91e8, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_91ef, 2); jmp(0x100b_91f7, 6); goto l_0x100b_91f7; /* jmp 0x100b91f7 */
        l_0x100b_91f1:
            ii(0x100b_91f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_91f4, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100b_91f7:
            ii(0x100b_91f7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_91fa, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_91fd, 4); cmp(ax, memw[ds, edx + 12]);            /* cmp ax, [edx+0xc] */
            ii(0x100b_9201, 2); if(jge(0x100b_921d, 0x1a)) goto l_0x100b_921d; /* jge 0x100b921d */
            ii(0x100b_9203, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_9207, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_920a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_920c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_920f, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100b_9212, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9214, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_9216, 5); call(Definitions.sys_delete, 0xa_cd49); /* call 0x10165f64 */
            ii(0x100b_921b, 2); jmp(0x100b_91f1, -0x2c); goto l_0x100b_91f1; /* jmp 0x100b91f1 */
        l_0x100b_921d:
            ii(0x100b_921d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9220, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x100b_9223, 5); call(Definitions.sys_delete, 0xa_cd3c); /* call 0x10165f64 */
            ii(0x100b_9228, 7); mov(memd[ss, ebp - 8], 0);              /* mov dword [ebp-0x8], 0x0 */
            ii(0x100b_922f, 2); jmp(0x100b_9237, 6); goto l_0x100b_9237; /* jmp 0x100b9237 */
        l_0x100b_9231:
            ii(0x100b_9231, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_9234, 3); inc(memd[ss, ebp - 8]);                 /* inc dword [ebp-0x8] */
        l_0x100b_9237:
            ii(0x100b_9237, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_923a, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100b_923d, 4); cmp(ax, memw[ds, edx + 12]);            /* cmp ax, [edx+0xc] */
            ii(0x100b_9241, 2); if(jge(0x100b_925d, 0x1a)) goto l_0x100b_925d; /* jge 0x100b925d */
            ii(0x100b_9243, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x100b_9247, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x100b_924a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_924c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_924f, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100b_9252, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100b_9254, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_9256, 5); call(Definitions.sys_delete, 0xa_cd09); /* call 0x10165f64 */
            ii(0x100b_925b, 2); jmp(0x100b_9231, -0x2c); goto l_0x100b_9231; /* jmp 0x100b9231 */
        l_0x100b_925d:
            ii(0x100b_925d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9260, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x100b_9263, 5); call(Definitions.sys_delete, 0xa_ccfc); /* call 0x10165f64 */
        l_0x100b_9268:
            ii(0x100b_9268, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_926b, 7); mov(memd[ds, eax + 4], 0);              /* mov dword [eax+0x4], 0x0 */
            ii(0x100b_9272, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_9275, 7); mov(memd[ds, eax + 8], 0);              /* mov dword [eax+0x8], 0x0 */
            ii(0x100b_927c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_927e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_927f, 1); pop(edi);                               /* pop edi */
            ii(0x100b_9280, 1); pop(esi);                               /* pop esi */
            ii(0x100b_9281, 1); pop(edx);                               /* pop edx */
            ii(0x100b_9282, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_9283, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_9284, 1); ret();                                  /* ret */
        }
    }
}
