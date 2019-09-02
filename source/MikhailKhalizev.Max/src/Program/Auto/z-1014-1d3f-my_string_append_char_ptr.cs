using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1d3f-70e81d31")]
        public void my_string_append_char_ptr()
        {
            ii(0x1014_1d3f, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_1d44, 5); call(Definitions.sys_check_available_stack_size, 0x2_4009); /* call 0x10165d52 */
            ii(0x1014_1d49, 1); push(ebx);                              /* push ebx */
            ii(0x1014_1d4a, 1); push(ecx);                              /* push ecx */
            ii(0x1014_1d4b, 1); push(esi);                              /* push esi */
            ii(0x1014_1d4c, 1); push(edi);                              /* push edi */
            ii(0x1014_1d4d, 1); push(ebp);                              /* push ebp */
            ii(0x1014_1d4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1d50, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_1d56, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_1d59, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_1d5c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1d5f, 5); call(Definitions.my_string_make_single_ref, 0x5f8); /* call 0x1014235c */
            ii(0x1014_1d64, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1d67, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1d69, 5); call(Definitions.my_strobj_get_len, -0x5_6e4a); /* call 0x100eaf24 */
            ii(0x1014_1d6e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_1d70, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_1d73, 5); call(Definitions.sys_strlen, 0x3_014f); /* call 0x10171ec7 */
            ii(0x1014_1d78, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1014_1d7a, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1014_1d7d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1d80, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1d82, 5); call(Definitions.my_strobj_get_size, 0x7d5); /* call 0x1014255c */
            ii(0x1014_1d87, 4); cmp(ax, memw[ss, ebp - 12]);            /* cmp ax, [ebp-0xc] */
            ii(0x1014_1d8b, 2); if(jge(0x1014_1daa, 0x1d)) goto l_0x1014_1daa; /* jge 0x10141daa */
            ii(0x1014_1d8d, 5); call(Definitions.my_set_al_1, 0x73a);   /* call 0x101424cc */
            ii(0x1014_1d92, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1014_1d94, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1014_1d96, 4); movsx(eax, memw[ss, ebp - 12]);         /* movsx eax, word [ebp-0xc] */
            ii(0x1014_1d9a, 5); call(Definitions.my_string_compute_capacity_from_length, 0x639); /* call 0x101423d8 */
            ii(0x1014_1d9f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1014_1da2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1da5, 5); call(Definitions.my_string_reserve, -0x248); /* call 0x10141b62 */
        l_0x1014_1daa:
            ii(0x1014_1daa, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_1dad, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1db0, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1db2, 5); call(Definitions.my_strobj_get_len, -0x5_6e93); /* call 0x100eaf24 */
            ii(0x1014_1db7, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1014_1dba, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1dbd, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1dbf, 5); call(Definitions.my_strobj_c_str, -0xb_85c8); /* call 0x100897fc */
            ii(0x1014_1dc4, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1014_1dc6, 5); call(Definitions.sys_strcpy, 0x2_4104); /* call 0x10165ecf */
            ii(0x1014_1dcb, 4); movsx(edx, memw[ss, ebp - 12]);         /* movsx edx, word [ebp-0xc] */
            ii(0x1014_1dcf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1dd2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1014_1dd4, 5); call(Definitions.my_strobj_set_len, 0x713); /* call 0x101424ec */
            ii(0x1014_1dd9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_1ddc, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1014_1ddf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_1de2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1de4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_1de5, 1); pop(edi);                               /* pop edi */
            ii(0x1014_1de6, 1); pop(esi);                               /* pop esi */
            ii(0x1014_1de7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_1de8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_1de9, 1); ret();                                  /* ret */
        }
    }
}
