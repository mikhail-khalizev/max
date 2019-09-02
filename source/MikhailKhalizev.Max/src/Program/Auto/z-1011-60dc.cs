using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_60dc-11672d93")]
        public void Method_1011_60dc()
        {
            ii(0x1011_60dc, 5); push(0x34);                             /* push 0x34 */
            ii(0x1011_60e1, 5); call(Definitions.sys_check_available_stack_size, 0x4_fc6c); /* call 0x10165d52 */
            ii(0x1011_60e6, 1); push(esi);                              /* push esi */
            ii(0x1011_60e7, 1); push(edi);                              /* push edi */
            ii(0x1011_60e8, 1); push(ebp);                              /* push ebp */
            ii(0x1011_60e9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_60eb, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_60f1, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1011_60f4, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1011_60f7, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1011_60fa, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x1011_60fd, 7); mov(memd[ss, ebp - 24], 0);             /* mov dword [ebp-0x18], 0x0 */
            ii(0x1011_6104, 7); mov(memd[ss, ebp - 20], 0);             /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_610b:
            ii(0x1011_610b, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1011_610f, 3); add(eax, memd[ss, ebp + 20]);           /* add eax, [ebp+0x14] */
            ii(0x1011_6112, 3); cmp(memb[ds, eax], 0xa);                /* cmp byte [eax], 0xa */
            ii(0x1011_6115, 2); if(jnz(0x1011_6135, 0x1e)) goto l_0x1011_6135; /* jnz 0x10116135 */
            ii(0x1011_6117, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_611a, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1011_611d, 1); cwde();                                 /* cwde */
            ii(0x1011_611e, 7); mov(memb[ds, eax + 0x101c_5184], 0x20); /* mov byte [eax+0x101c5184], 0x20 */
            ii(0x1011_6125, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_6128, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1011_612b, 1); cwde();                                 /* cwde */
            ii(0x1011_612c, 7); mov(memb[ds, eax + 0x101c_5184], 0);    /* mov byte [eax+0x101c5184], 0x0 */
            ii(0x1011_6133, 2); jmp(0x1011_614b, 0x16); goto l_0x1011_614b; /* jmp 0x1011614b */
        l_0x1011_6135:
            ii(0x1011_6135, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1011_6139, 3); add(edx, memd[ss, ebp + 20]);           /* add edx, [ebp+0x14] */
            ii(0x1011_613c, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1011_613f, 3); inc(memd[ss, ebp - 20]);                /* inc dword [ebp-0x14] */
            ii(0x1011_6142, 1); cwde();                                 /* cwde */
            ii(0x1011_6143, 2); mov(dl, memb[ds, edx]);                 /* mov dl, [edx] */
            ii(0x1011_6145, 6); mov(memb[ds, eax + 0x101c_5184], dl);   /* mov [eax+0x101c5184], dl */
        l_0x1011_614b:
            ii(0x1011_614b, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1011_614e, 3); inc(memd[ss, ebp - 24]);                /* inc dword [ebp-0x18] */
            ii(0x1011_6151, 1); cwde();                                 /* cwde */
            ii(0x1011_6152, 3); add(eax, memd[ss, ebp + 20]);           /* add eax, [ebp+0x14] */
            ii(0x1011_6155, 3); cmp(memb[ds, eax], 0);                  /* cmp byte [eax], 0x0 */
            ii(0x1011_6158, 2); if(jnz(0x1011_610b, -0x4f)) goto l_0x1011_610b; /* jnz 0x1011610b */
            ii(0x1011_615a, 4); movsx(eax, memw[ss, ebp - 20]);         /* movsx eax, word [ebp-0x14] */
            ii(0x1011_615e, 7); mov(memb[ds, eax + 0x101c_5184], 0);    /* mov byte [eax+0x101c5184], 0x0 */
            ii(0x1011_6165, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_6167, 1); push(eax);                              /* push eax */
            ii(0x1011_6168, 4); movsx(eax, memw[ss, ebp + 24]);         /* movsx eax, word [ebp+0x18] */
            ii(0x1011_616c, 1); push(eax);                              /* push eax */
            ii(0x1011_616d, 5); mov(eax, 0x101c_5184);                  /* mov eax, 0x101c5184 */
            ii(0x1011_6172, 1); push(eax);                              /* push eax */
            ii(0x1011_6173, 3); mov(ecx, memd[ss, ebp + 16]);           /* mov ecx, [ebp+0x10] */
            ii(0x1011_6176, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1011_6179, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1011_617d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1011_6180, 5); call(0x1011_5aa9, -0x6dc);              /* call 0x10115aa9 */
            ii(0x1011_6185, 5); cmp(memw[ss, ebp + 28], 0);             /* cmp word [ebp+0x1c], 0x0 */
            ii(0x1011_618a, 2); if(jz(0x1011_619a, 0xe)) goto l_0x1011_619a; /* jz 0x1011619a */
            ii(0x1011_618c, 3); mov(edx, memd[ss, ebp - 16]);           /* mov edx, [ebp-0x10] */
            ii(0x1011_618f, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1011_6192, 3); mov(eax, memd[ds, eax + 18]);           /* mov eax, [eax+0x12] */
            ii(0x1011_6195, 5); call(Definitions.sys_display_draw_1, 0x5_130e); /* call 0x101674a8 */
        l_0x1011_619a:
            ii(0x1011_619a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_619c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_619d, 1); pop(edi);                               /* pop edi */
            ii(0x1011_619e, 1); pop(esi);                               /* pop esi */
            ii(0x1011_619f, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}
