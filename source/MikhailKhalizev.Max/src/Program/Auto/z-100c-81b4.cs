using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("36e8136e-b88b-4e5d-b7ad-9199cde91d88")]
        public void Method_100c_81b4()
        {
            ii(0x100c_81b4, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100c_81b9, 5); calld(Definitions.sys_check_available_stack_size, 0x9_db94); /* call 0x10165d52 */
            ii(0x100c_81be, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_81bf, 1); pushd(esi);                             /* push esi */
            ii(0x100c_81c0, 1); pushd(edi);                             /* push edi */
            ii(0x100c_81c1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_81c2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_81c4, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100c_81ca, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_81cd, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100c_81d0, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100c_81d3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100c_81d6, 5); calld(Definitions.my_ctor_0x101b_4184, -0x5_16eb); /* call 0x10076af0 */
            ii(0x100c_81db, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_81de, 4); mov(ax, memw_a32[ds, eax + 0xb]);       /* mov ax, [eax+0xb] */
            ii(0x100c_81e2, 4); mov(memw_a32[ss, ebp - 0x10], ax);      /* mov [ebp-0x10], ax */
            ii(0x100c_81e6, 2); jmpd(0x100c_81ef, 0x7); goto l_0x100c_81ef; /* jmp 0x100c81ef */
        l_0x100c_81e8:
            ii(0x100c_81e8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100c_81eb, 4); inc(memw_a32[ss, ebp - 0x10]);          /* inc word [ebp-0x10] */
        l_0x100c_81ef:
            ii(0x100c_81ef, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_81f2, 3); mov(eax, memd_a32[ds, eax + 0x13]);     /* mov eax, [eax+0x13] */
            ii(0x100c_81f5, 3); sub(eax, 0x3);                          /* sub eax, 0x3 */
            ii(0x100c_81f8, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100c_81fc, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_81fe, 2); if(jged(0x100c_8251, 0x51)) goto l_0x100c_8251; /* jge 0x100c8251 */
            ii(0x100c_8200, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8203, 4); mov(ax, memw_a32[ds, eax + 0xf]);       /* mov ax, [eax+0xf] */
            ii(0x100c_8207, 4); mov(memw_a32[ss, ebp - 0xe], ax);       /* mov [ebp-0xe], ax */
            ii(0x100c_820b, 2); jmpd(0x100c_8214, 0x7); goto l_0x100c_8214; /* jmp 0x100c8214 */
        l_0x100c_820d:
            ii(0x100c_820d, 3); mov(eax, memd_a32[ss, ebp - 0xe]);      /* mov eax, [ebp-0xe] */
            ii(0x100c_8210, 4); inc(memw_a32[ss, ebp - 0xe]);           /* inc word [ebp-0xe] */
        l_0x100c_8214:
            ii(0x100c_8214, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8217, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x100c_821a, 3); sub(eax, 0x3);                          /* sub eax, 0x3 */
            ii(0x100c_821d, 4); movsx(edx, memw_a32[ss, ebp - 0xe]);    /* movsx edx, word [ebp-0xe] */
            ii(0x100c_8221, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_8223, 2); if(jged(0x100c_824f, 0x2a)) goto l_0x100c_824f; /* jge 0x100c824f */
            ii(0x100c_8225, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100c_8228, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_822b, 5); calld(0x1007_5e64, -0x5_23cc);          /* call 0x10075e64 */
            ii(0x100c_8230, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_8232, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100c_8236, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_8238, 3); mov(dl, memb_a32[ss, ebp - 0x4]);       /* mov dl, [ebp-0x4] */
            ii(0x100c_823b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_823e, 5); calld(0x100c_7f78, -0x2cb);             /* call 0x100c7f78 */
            ii(0x100c_8243, 2); test(al, al);                           /* test al, al */
            ii(0x100c_8245, 2); if(jzd(0x100c_824d, 0x6)) goto l_0x100c_824d; /* jz 0x100c824d */
            ii(0x100c_8247, 4); mov(memb_a32[ss, ebp - 0x18], 0x1);     /* mov byte [ebp-0x18], 0x1 */
            ii(0x100c_824b, 2); jmpd(0x100c_8255, 0x8); goto l_0x100c_8255; /* jmp 0x100c8255 */
        l_0x100c_824d:
            ii(0x100c_824d, 2); jmpd(0x100c_820d, -0x42); goto l_0x100c_820d; /* jmp 0x100c820d */
        l_0x100c_824f:
            ii(0x100c_824f, 2); jmpd(0x100c_81e8, -0x69); goto l_0x100c_81e8; /* jmp 0x100c81e8 */
        l_0x100c_8251:
            ii(0x100c_8251, 4); mov(memb_a32[ss, ebp - 0x18], 0);       /* mov byte [ebp-0x18], 0x0 */
        l_0x100c_8255:
            ii(0x100c_8255, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x100c_8258, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_825a, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_825b, 1); popd(edi);                              /* pop edi */
            ii(0x100c_825c, 1); popd(esi);                              /* pop esi */
            ii(0x100c_825d, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_825e, 1); retd(); return;                         /* ret */
        }
    }
}
