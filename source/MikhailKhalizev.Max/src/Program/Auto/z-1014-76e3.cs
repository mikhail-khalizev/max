using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34cca029-af1d-404d-923c-129d8567b772")]
        public void Method_1014_76e3()
        {
            ii(0x1014_76e3, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_76e8, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e665); /* call 0x10165d52 */
            ii(0x1014_76ed, 1); pushd(esi);                             /* push esi */
            ii(0x1014_76ee, 1); pushd(edi);                             /* push edi */
            ii(0x1014_76ef, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_76f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_76f2, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_76f8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_76fb, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1014_76fe, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1014_7701, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1014_7704, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_7707, 5); calld(0x1014_7395, -0x377);             /* call 0x10147395 */
            ii(0x1014_770c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_770f, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7711, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_7714, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9834); /* call 0x10180f4d */
            ii(0x1014_7719, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_771c, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_771e, 5); mov(eax, StringDefinitions.Control33);  /* mov eax, 0x101ad154 */
            ii(0x1014_7723, 5); calld(/* sys */ 0x1018_0f4d, 0x3_9825); /* call 0x10180f4d */
            ii(0x1014_7728, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_772c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_772f, 5); calld(0x1014_58f2, -0x1e42);            /* call 0x101458f2 */
            ii(0x1014_7734, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_7737, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x1014_773b, 2); if(jzd(0x1014_774b, 0xe)) goto l_0x1014_774b; /* jz 0x1014774b */
            ii(0x1014_773d, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_7740, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1014_7742, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1014_7747, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1014_7749, 2); if(jnzd(0x1014_775c, 0x11)) goto l_0x1014_775c; /* jnz 0x1014775c */
        l_0x1014_774b:
            ii(0x1014_774b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_774e, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7750, 5); mov(eax, StringDefinitions.Unknown2);   /* mov eax, 0x101ad158 */
            ii(0x1014_7755, 5); calld(/* sys */ 0x1018_0f4d, 0x3_97f3); /* call 0x10180f4d */
            ii(0x1014_775a, 2); jmpd(0x1014_7769, 0xd); goto l_0x1014_7769; /* jmp 0x10147769 */
        l_0x1014_775c:
            ii(0x1014_775c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_775f, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_7761, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_7764, 5); calld(/* sys */ 0x1018_0f4d, 0x3_97e4); /* call 0x10180f4d */
        l_0x1014_7769:
            ii(0x1014_7769, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_776c, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1014_776e, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1014_7773, 5); calld(/* sys */ 0x1017_29f1, 0x2_b279); /* call 0x101729f1 */
            ii(0x1014_7778, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_777a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_777b, 1); popd(edi);                              /* pop edi */
            ii(0x1014_777c, 1); popd(esi);                              /* pop esi */
            ii(0x1014_777d, 1); retd(); return;                         /* ret */
        }
    }
}