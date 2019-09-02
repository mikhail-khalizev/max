using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_c936-5da2f185")]
        public void Method_1011_c936()
        {
            ii(0x1011_c936, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_c93b, 5); call(Definitions.sys_check_available_stack_size, 0x4_9412); /* call 0x10165d52 */
            ii(0x1011_c940, 1); push(esi);                              /* push esi */
            ii(0x1011_c941, 1); push(edi);                              /* push edi */
            ii(0x1011_c942, 1); push(ebp);                              /* push ebp */
            ii(0x1011_c943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_c945, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1011_c94b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_c94e, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1011_c951, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1011_c954, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1011_c957, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1011_c95a, 5); call(Definitions.my_ctor_0x101b_4184, -0xa_5e6f); /* call 0x10076af0 */
            ii(0x1011_c95f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c962, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1011_c965, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_c968, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1011_c96b, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_c96d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c96f, 5); call(/* sys */ 0x1016_5df8, 0x4_9484);  /* call 0x10165df8 */
            ii(0x1011_c974, 4); mov(memw[ss, ebp - 0x14], ax);          /* mov [ebp-0x14], ax */
            ii(0x1011_c978, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_c97b, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1011_c97d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_c980, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_c983, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1011_c985, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1011_c988, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1011_c98a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1011_c98c, 5); call(/* sys */ 0x1016_5df8, 0x4_9467);  /* call 0x10165df8 */
            ii(0x1011_c991, 4); mov(memw[ss, ebp - 0x12], ax);          /* mov [ebp-0x12], ax */
            ii(0x1011_c995, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_c998, 4); cmp(ax, memw[ss, ebp - 0x12]);          /* cmp ax, [ebp-0x12] */
            ii(0x1011_c99c, 2); if(jle(0x1011_c9ad, 0xf)) goto l_0x1011_c9ad; /* jle 0x1011c9ad */
            ii(0x1011_c99e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1011_c9a1, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c9a3, 3); mov(edx, memd[ss, ebp - 0x12]);         /* mov edx, [ebp-0x12] */
            ii(0x1011_c9a6, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c9a8, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
            ii(0x1011_c9ab, 2); jmp(0x1011_c9ba, 0xd); goto l_0x1011_c9ba; /* jmp 0x1011c9ba */
        l_0x1011_c9ad:
            ii(0x1011_c9ad, 3); mov(eax, memd[ss, ebp - 0x12]);         /* mov eax, [ebp-0x12] */
            ii(0x1011_c9b0, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c9b2, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1011_c9b5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c9b7, 3); mov(memd[ss, ebp - 0x18], edx);         /* mov [ebp-0x18], edx */
        l_0x1011_c9ba:
            ii(0x1011_c9ba, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_c9bd, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_c9c0, 4); cmp(ax, memw[ds, edx + 0xc]);           /* cmp ax, [edx+0xc] */
            ii(0x1011_c9c4, 2); if(jle(0x1011_c9d0, 0xa)) goto l_0x1011_c9d0; /* jle 0x1011c9d0 */
            ii(0x1011_c9c6, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_c9c9, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1011_c9cc, 4); mov(memw[ds, edx + 0xc], ax);           /* mov [edx+0xc], ax */
        l_0x1011_c9d0:
            ii(0x1011_c9d0, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1011_c9d4, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1011_c9d6, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1011_c9d8, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_c9db, 3); mov(edx, memd[ds, eax + 8]);            /* mov edx, [eax+0x8] */
            ii(0x1011_c9de, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1011_c9e0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_c9e3, 3); cmp(ax, memw[ds, edx]);                 /* cmp ax, [edx] */
            ii(0x1011_c9e6, 2); if(jge(0x1011_ca04, 0x1c)) goto l_0x1011_ca04; /* jge 0x1011ca04 */
            ii(0x1011_c9e8, 4); movsx(edx, memw[ss, ebp - 0x18]);       /* movsx edx, word [ebp-0x18] */
            ii(0x1011_c9ec, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1011_c9ee, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_c9f1, 3); mov(eax, memd[ds, eax + 8]);            /* mov eax, [eax+0x8] */
            ii(0x1011_c9f4, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_c9f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_c9f9, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1011_c9fc, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1011_c9ff, 3); dec(memd[ss, ebp - 0x18]);              /* dec dword [ebp-0x18] */
            ii(0x1011_ca02, 2); jmp(0x1011_c9d0, -0x34); goto l_0x1011_c9d0; /* jmp 0x1011c9d0 */
        l_0x1011_ca04:
            ii(0x1011_ca04, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_ca06, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_ca07, 1); pop(edi);                               /* pop edi */
            ii(0x1011_ca08, 1); pop(esi);                               /* pop esi */
            ii(0x1011_ca09, 1); ret();                                  /* ret */
        }
    }
}
