using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_701e-afd2a483")]
        public void Method_100d_701e()
        {
            ii(0x100d_701e, 5); push(0x34);                             /* push 0x34 */
            ii(0x100d_7023, 5); call(Definitions.sys_check_available_stack_size, 0x8_ed2a); /* call 0x10165d52 */
            ii(0x100d_7028, 1); push(esi);                              /* push esi */
            ii(0x100d_7029, 1); push(edi);                              /* push edi */
            ii(0x100d_702a, 1); push(ebp);                              /* push ebp */
            ii(0x100d_702b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_702d, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100d_7033, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_7036, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100d_7039, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100d_703c, 3); mov(memd[ss, ebp - 0x8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100d_703f, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_7043, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7045, 6); if(jle(0x100d_7103, 0xb8)) goto l_0x100d_7103; /* jle 0x100d7103 */
            ii(0x100d_704b, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100d_704f, 5); call(Definitions.my_get_res_data_by_id, 0x5_cf84); /* call 0x10133fd8 */
            ii(0x100d_7054, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100d_7057, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_705a, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100d_705d, 4); cmp(ax, memw[ds, edx + 0x2]);           /* cmp ax, [edx+0x2] */
            ii(0x100d_7061, 2); if(jle(0x100d_706d, 0xa)) goto l_0x100d_706d; /* jle 0x100d706d */
            ii(0x100d_7063, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_7066, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100d_706a, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
        l_0x100d_706d:
            ii(0x100d_706d, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_7070, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_7073, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100d_7077, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_7079, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100d_707b, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100d_707e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100d_7080, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100d_7082, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_7085, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_7088, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_708b, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100d_708e, 4); movsx(eax, memw[ss, ebp - 0x1c]);       /* movsx eax, word [ebp-0x1c] */
            ii(0x100d_7092, 3); add(memd[ss, ebp - 0x10], eax);         /* add [ebp-0x10], eax */
            ii(0x100d_7095, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_7098, 3); mov(al, memb[ds, eax + 0x8]);           /* mov al, [eax+0x8] */
            ii(0x100d_709b, 3); mov(memb[ss, ebp - 0x14], al);          /* mov [ebp-0x14], al */
            ii(0x100d_709e, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_70a5, 2); jmp(0x100d_70ad, 0x6); goto l_0x100d_70ad; /* jmp 0x100d70ad */
        l_0x100d_70a7:
            ii(0x100d_70a7, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_70aa, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x100d_70ad:
            ii(0x100d_70ad, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_70b0, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100d_70b4, 2); if(jge(0x100d_7103, 0x4d)) goto l_0x100d_7103; /* jge 0x100d7103 */
            ii(0x100d_70b6, 7); mov(memd[ss, ebp - 0x1c], 0);           /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100d_70bd, 2); jmp(0x100d_70c5, 0x6); goto l_0x100d_70c5; /* jmp 0x100d70c5 */
        l_0x100d_70bf:
            ii(0x100d_70bf, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_70c2, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100d_70c5:
            ii(0x100d_70c5, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_70c8, 3); mov(edx, memd[ss, ebp - 0x20]);         /* mov edx, [ebp-0x20] */
            ii(0x100d_70cb, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x100d_70ce, 2); if(jge(0x100d_70f2, 0x22)) goto l_0x100d_70f2; /* jge 0x100d70f2 */
            ii(0x100d_70d0, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_70d3, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x100d_70d5, 3); cmp(al, memb[ss, ebp - 0x14]);          /* cmp al, [ebp-0x14] */
            ii(0x100d_70d8, 2); if(jz(0x100d_70e4, 0xa)) goto l_0x100d_70e4; /* jz 0x100d70e4 */
            ii(0x100d_70da, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_70dd, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x100d_70df, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_70e2, 2); mov(memb[ds, eax], dl);                 /* mov [eax], dl */
        l_0x100d_70e4:
            ii(0x100d_70e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_70e7, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
            ii(0x100d_70ea, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_70ed, 3); inc(memd[ss, ebp - 0x24]);              /* inc dword [ebp-0x24] */
            ii(0x100d_70f0, 2); jmp(0x100d_70bf, -0x33); goto l_0x100d_70bf; /* jmp 0x100d70bf */
        l_0x100d_70f2:
            ii(0x100d_70f2, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_70f5, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100d_70f8, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100d_70fc, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100d_70fe, 3); add(memd[ss, ebp - 0x10], edx);         /* add [ebp-0x10], edx */
            ii(0x100d_7101, 2); jmp(0x100d_70a7, -0x5c); goto l_0x100d_70a7; /* jmp 0x100d70a7 */
        l_0x100d_7103:
            ii(0x100d_7103, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7105, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_7106, 1); pop(edi);                               /* pop edi */
            ii(0x100d_7107, 1); pop(esi);                               /* pop esi */
            ii(0x100d_7108, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}
