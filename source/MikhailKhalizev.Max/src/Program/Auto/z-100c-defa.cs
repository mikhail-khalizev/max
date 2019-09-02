using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_defa-422b2fa0")]
        public void Method_100c_defa()
        {
            ii(0x100c_defa, 5); push(0x34);                             /* push 0x34 */
            ii(0x100c_deff, 5); call(Definitions.sys_check_available_stack_size, 0x9_7e4e); /* call 0x10165d52 */
            ii(0x100c_df04, 1); push(ebx);                              /* push ebx */
            ii(0x100c_df05, 1); push(ecx);                              /* push ecx */
            ii(0x100c_df06, 1); push(edx);                              /* push edx */
            ii(0x100c_df07, 1); push(esi);                              /* push esi */
            ii(0x100c_df08, 1); push(edi);                              /* push edi */
            ii(0x100c_df09, 1); push(ebp);                              /* push ebp */
            ii(0x100c_df0a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_df0c, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_df12, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_df15, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100c_df1c, 7); mov(memd[ss, ebp - 8], 0x4b);           /* mov dword [ebp-0x8], 0x4b */
        l_0x100c_df23:
            ii(0x100c_df23, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_df26, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x100c_df2a, 2); if(jge(0x100c_df82, 0x56)) goto l_0x100c_df82; /* jge 0x100cdf82 */
            ii(0x100c_df2c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_df2f, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100c_df32, 1); cwde();                                 /* cwde */
            ii(0x100c_df33, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_df35, 7); mov(ax, memw[ds, eax + 0x101b_7b78]);   /* mov ax, [eax+0x101b7b78] */
            ii(0x100c_df3c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_df3f, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_df42, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100c_df45, 1); cwde();                                 /* cwde */
            ii(0x100c_df46, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_df48, 7); mov(ax, memw[ds, eax + 0x101b_7b78]);   /* mov ax, [eax+0x101b7b78] */
            ii(0x100c_df4f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x100c_df52:
            ii(0x100c_df52, 3); dec(memd[ss, ebp - 0x10]);              /* dec dword [ebp-0x10] */
            ii(0x100c_df55, 5); cmp(memw[ss, ebp - 0x10], -1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100c_df5a, 2); if(jz(0x100c_df80, 0x24)) goto l_0x100c_df80; /* jz 0x100cdf80 */
            ii(0x100c_df5c, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_df5f, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
            ii(0x100c_df62, 1); cwde();                                 /* cwde */
            ii(0x100c_df63, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100c_df65, 6); mov(edx, memd[ds, eax + 0x101b_7b76]);  /* mov edx, [eax+0x101b7b76] */
            ii(0x100c_df6b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_df6e, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x100c_df72, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_df74, 2); if(jnz(0x100c_df7e, 8)) goto l_0x100c_df7e; /* jnz 0x100cdf7e */
            ii(0x100c_df76, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_df79, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100c_df7c, 2); jmp(0x100c_df89, 0xb); goto l_0x100c_df89; /* jmp 0x100cdf89 */
        l_0x100c_df7e:
            ii(0x100c_df7e, 2); jmp(0x100c_df52, -0x2e); goto l_0x100c_df52; /* jmp 0x100cdf52 */
        l_0x100c_df80:
            ii(0x100c_df80, 2); jmp(0x100c_df23, -0x5f); goto l_0x100c_df23; /* jmp 0x100cdf23 */
        l_0x100c_df82:
            ii(0x100c_df82, 7); mov(memd[ss, ebp - 0x18], 0xffff_ffff); /* mov dword [ebp-0x18], 0xffffffff */
        l_0x100c_df89:
            ii(0x100c_df89, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100c_df8c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_df8e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_df8f, 1); pop(edi);                               /* pop edi */
            ii(0x100c_df90, 1); pop(esi);                               /* pop esi */
            ii(0x100c_df91, 1); pop(edx);                               /* pop edx */
            ii(0x100c_df92, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_df93, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_df94, 1); ret();                                  /* ret */
        }
    }
}
