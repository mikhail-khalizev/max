using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_e9a0-8e9fe204")]
        public void Method_1010_e9a0()
        {
            ii(0x1010_e9a0, 5); push(0x54);                             /* push 0x54 */
            ii(0x1010_e9a5, 5); call(Definitions.sys_check_available_stack_size, 0x5_73a8); /* call 0x10165d52 */
            ii(0x1010_e9aa, 1); push(ebx);                              /* push ebx */
            ii(0x1010_e9ab, 1); push(ecx);                              /* push ecx */
            ii(0x1010_e9ac, 1); push(edx);                              /* push edx */
            ii(0x1010_e9ad, 1); push(esi);                              /* push esi */
            ii(0x1010_e9ae, 1); push(edi);                              /* push edi */
            ii(0x1010_e9af, 1); push(ebp);                              /* push ebp */
            ii(0x1010_e9b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_e9b2, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1010_e9b8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_e9bb, 7); mov(memd[ss, ebp - 0x28], 0x101b_ac94); /* mov dword [ebp-0x28], 0x101bac94 */
            ii(0x1010_e9c2, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1010_e9c7, 5); call(/* sys */ 0x1016_a24c, 0x5_b880);  /* call 0x1016a24c */
            ii(0x1010_e9cc, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x1010_e9d1, 5); call(Definitions.sys_new, 0x5_742a);    /* call 0x10165e00 */
            ii(0x1010_e9d6, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1010_e9d9, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_e9dc, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_e9df, 4); cmp(memd[ss, ebp - 0x20], 0);           /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1010_e9e3, 2); if(jz(0x1010_ea1b, 0x36)) goto l_0x1010_ea1b; /* jz 0x1010ea1b */
            ii(0x1010_e9e5, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_e9e8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_e9ea, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1010_e9ed, 1); push(eax);                              /* push eax */
            ii(0x1010_e9ee, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_e9f1, 3); movsx(ecx, memw[ds, eax]);              /* movsx ecx, word [eax] */
            ii(0x1010_e9f4, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_e9f7, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1010_e9fb, 1); inc(eax);                               /* inc eax */
            ii(0x1010_e9fc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_e9ff, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_ea02, 3); mov(edx, memd[ds, eax + 6]);            /* mov edx, [eax+0x6] */
            ii(0x1010_ea05, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_ea08, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x1010_ea0b, 5); call(Definitions.my_ctor_c17, -0x4_0601); /* call 0x100ce40f */
            ii(0x1010_ea10, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x1010_ea13, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1010_ea16, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1010_ea19, 2); jmp(0x1010_ea21, 6); goto l_0x1010_ea21; /* jmp 0x1010ea21 */
        l_0x1010_ea1b:
            ii(0x1010_ea1b, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x1010_ea1e, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x1010_ea21:
            ii(0x1010_ea21, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1010_ea24, 5); mov(memd[ds, 0x101c_4df0], eax);        /* mov [0x101c4df0], eax */
            ii(0x1010_ea29, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1010_ea2c, 5); call(0x100d_5224, -0x3_980d);           /* call 0x100d5224 */
            ii(0x1010_ea31, 1); push(eax);                              /* push eax */
            ii(0x1010_ea32, 3); lea(eax, memd[ss, ebp - 0xc]);          /* lea eax, [ebp-0xc] */
            ii(0x1010_ea35, 5); call(0x100d_5250, -0x3_97ea);           /* call 0x100d5250 */
            ii(0x1010_ea3a, 1); push(eax);                              /* push eax */
            ii(0x1010_ea3b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1010_ea3e, 5); call(0x100d_527c, -0x3_97c7);           /* call 0x100d527c */
            ii(0x1010_ea43, 1); push(eax);                              /* push eax */
            ii(0x1010_ea44, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1010_ea47, 5); call(0x100d_52a8, -0x3_97a4);           /* call 0x100d52a8 */
            ii(0x1010_ea4c, 1); push(eax);                              /* push eax */
            ii(0x1010_ea4d, 5); call(0x100d_52d4, -0x3_977e);           /* call 0x100d52d4 */
            ii(0x1010_ea52, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_ea55, 5); call(0x100d_52f8, -0x3_9762);           /* call 0x100d52f8 */
            ii(0x1010_ea5a, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_ea5d, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_ea60, 3); mov(edx, memd[ds, eax + 0xa]);          /* mov edx, [eax+0xa] */
            ii(0x1010_ea63, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_ea68, 5); call(0x100c_ef64, -0x3_fb09);           /* call 0x100cef64 */
            ii(0x1010_ea6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_ea6f, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_ea74, 5); call(0x100d_5194, -0x3_98e5);           /* call 0x100d5194 */
            ii(0x1010_ea79, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x1010_ea7e, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_ea83, 5); call(0x100d_5134, -0x3_9954);           /* call 0x100d5134 */
            ii(0x1010_ea88, 5); mov(edx, 0x7000);                       /* mov edx, 0x7000 */
            ii(0x1010_ea8d, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_ea92, 5); call(0x100d_5164, -0x3_9933);           /* call 0x100d5164 */
            ii(0x1010_ea97, 3); mov(eax, memd[ss, ebp - 0x28]);         /* mov eax, [ebp-0x28] */
            ii(0x1010_ea9a, 3); mov(edx, memd[ds, eax + 0x14]);         /* mov edx, [eax+0x14] */
            ii(0x1010_ea9d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_eaa0, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_eaa5, 5); call(0x100d_50d4, -0x3_99d6);           /* call 0x100d50d4 */
            ii(0x1010_eaaa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_eaad, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_eaaf, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1010_eab2, 5); mov(eax, memd[ds, 0x101c_4df0]);        /* mov eax, [0x101c4df0] */
            ii(0x1010_eab7, 5); call(0x100c_f85c, -0x3_f260);           /* call 0x100cf85c */
            ii(0x1010_eabc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_eabe, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_eabf, 1); pop(edi);                               /* pop edi */
            ii(0x1010_eac0, 1); pop(esi);                               /* pop esi */
            ii(0x1010_eac1, 1); pop(edx);                               /* pop edx */
            ii(0x1010_eac2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_eac3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_eac4, 1); ret();                                  /* ret */
        }
    }
}
