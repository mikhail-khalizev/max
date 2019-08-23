using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7c5e-9a483c91")]
        public void my_ctor_c19()
        {
            ii(0x100d_7c5e, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100d_7c63, 5); call(Definitions.sys_check_available_stack_size, 0x8_e0ea); /* call 0x10165d52 */
            ii(0x100d_7c68, 1); push(esi);                              /* push esi */
            ii(0x100d_7c69, 1); push(edi);                              /* push edi */
            ii(0x100d_7c6a, 1); push(ebp);                              /* push ebp */
            ii(0x100d_7c6b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7c6d, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_7c73, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_7c76, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100d_7c79, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100d_7c7c, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100d_7c7f, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100d_7c83, 5); call(Definitions.my_get_res_data_by_id, 0x5_c350); /* call 0x10133fd8 */
            ii(0x100d_7c88, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x100d_7c8b, 4); cmp(memd[ss, ebp - 0x14], 0);           /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_7c8f, 2); if(jz(0x100d_7c9a, 0x9)) goto l_0x100d_7c9a; /* jz 0x100d7c9a */
            ii(0x100d_7c91, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_7c98, 2); jmp(0x100d_7cb3, 0x19); goto l_0x100d_7cb3; /* jmp 0x100d7cb3 */
        l_0x100d_7c9a:
            ii(0x100d_7c9a, 5); mov(ecx, 0x245);                        /* mov ecx, 0x245 */
            ii(0x100d_7c9f, 5); mov(ebx, StringDefinitions.CommoCpp);   /* mov ebx, 0x101a17f4 */
            ii(0x100d_7ca4, 5); mov(edx, StringDefinitions.SpriteNotEqual0); /* mov edx, 0x101a17fe */
            ii(0x100d_7ca9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_7cab, 5); call(Definitions.sys_assert, 0x8_e0e2); /* call 0x10165d92 */
            ii(0x100d_7cb0, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
        l_0x100d_7cb3:
            ii(0x100d_7cb3, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_7cb7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7cb9, 2); if(jl(0x100d_7cc7, 0xc)) goto l_0x100d_7cc7; /* jl 0x100d7cc7 */
            ii(0x100d_7cbb, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_7cbe, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_7cc1, 4); mov(memw[ds, edx + 0x4], ax);           /* mov [edx+0x4], ax */
            ii(0x100d_7cc5, 2); jmp(0x100d_7cd5, 0xe); goto l_0x100d_7cd5; /* jmp 0x100d7cd5 */
        l_0x100d_7cc7:
            ii(0x100d_7cc7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_7cca, 4); mov(dx, memw[ds, eax + 0x4]);           /* mov dx, [eax+0x4] */
            ii(0x100d_7cce, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7cd1, 4); mov(memw[ds, eax + 0x4], dx);           /* mov [eax+0x4], dx */
        l_0x100d_7cd5:
            ii(0x100d_7cd5, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_7cd9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100d_7cdb, 2); if(jl(0x100d_7ce9, 0xc)) goto l_0x100d_7ce9; /* jl 0x100d7ce9 */
            ii(0x100d_7cdd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_7ce0, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_7ce3, 4); mov(memw[ds, edx + 0x6], ax);           /* mov [edx+0x6], ax */
            ii(0x100d_7ce7, 2); jmp(0x100d_7cf7, 0xe); goto l_0x100d_7cf7; /* jmp 0x100d7cf7 */
        l_0x100d_7ce9:
            ii(0x100d_7ce9, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_7cec, 4); mov(dx, memw[ds, eax + 0x6]);           /* mov dx, [eax+0x6] */
            ii(0x100d_7cf0, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7cf3, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
        l_0x100d_7cf7:
            ii(0x100d_7cf7, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_7cfa, 3); mov(dx, memw[ds, eax]);                 /* mov dx, [eax] */
            ii(0x100d_7cfd, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7d00, 4); mov(memw[ds, eax + 0x8], dx);           /* mov [eax+0x8], dx */
            ii(0x100d_7d04, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_7d07, 4); mov(dx, memw[ds, eax + 0x2]);           /* mov dx, [eax+0x2] */
            ii(0x100d_7d0b, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7d0e, 4); mov(memw[ds, eax + 0xa], dx);           /* mov [eax+0xa], dx */
            ii(0x100d_7d12, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_7d15, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_7d18, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x100d_7d1b, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x100d_7d1d, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7d20, 4); mov(memb[ds, eax + 0xc], 0);            /* mov byte [eax+0xc], 0x0 */
            ii(0x100d_7d24, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_7d27, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_7d2a, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_7d2d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_7d2f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_7d30, 1); pop(edi);                               /* pop edi */
            ii(0x100d_7d31, 1); pop(esi);                               /* pop esi */
            ii(0x100d_7d32, 1); ret();                                  /* ret */
        }
    }
}
