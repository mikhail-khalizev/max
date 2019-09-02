using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8fc2-a0e82f9c")]
        public void Method_1015_8fc2()
        {
            ii(0x1015_8fc2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_8fc7, 5); call(Definitions.sys_check_available_stack_size, 0xcd86); /* call 0x10165d52 */
            ii(0x1015_8fcc, 1); push(ebx);                              /* push ebx */
            ii(0x1015_8fcd, 1); push(ecx);                              /* push ecx */
            ii(0x1015_8fce, 1); push(esi);                              /* push esi */
            ii(0x1015_8fcf, 1); push(edi);                              /* push edi */
            ii(0x1015_8fd0, 1); push(ebp);                              /* push ebp */
            ii(0x1015_8fd1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8fd3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_8fd9, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_8fdc, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_8fdf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_8fe2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_8fe5, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_8fea, 5); call(0x100f_448c, -0x6_4b63);           /* call 0x100f448c */
            ii(0x1015_8fef, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_8ff2, 5); call(0x1008_aa4c, -0xc_e5ab);           /* call 0x1008aa4c */
            ii(0x1015_8ff7, 2); cmp(al, 2);                             /* cmp al, 0x2 */
            ii(0x1015_8ff9, 2); if(jnz(0x1015_900f, 0x14)) goto l_0x1015_900f; /* jnz 0x1015900f */
            ii(0x1015_8ffb, 5); mov(ebx, 0x2b);                         /* mov ebx, 0x2b */
            ii(0x1015_9000, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1015_9005, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_9008, 5); call(0x1016_3053, 0xa046);              /* call 0x10163053 */
            ii(0x1015_900d, 2); jmp(0x1015_9053, 0x44); goto l_0x1015_9053; /* jmp 0x10159053 */
        l_0x1015_900f:
            ii(0x1015_900f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_9012, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x1015_9015, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_9018, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_901a, 2); if(jnz(0x1015_9041, 0x25)) goto l_0x1015_9041; /* jnz 0x10159041 */
            ii(0x1015_901c, 5); call(0x100c_aa00, -0x8_e621);           /* call 0x100caa00 */
            ii(0x1015_9021, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_9026, 1); push(eax);                              /* push eax */
            ii(0x1015_9027, 5); call(0x100c_aa20, -0x8_e60c);           /* call 0x100caa20 */
            ii(0x1015_902c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1015_902e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_9030, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1015_9035, 5); mov(eax, StringDefinitions.MinelayerIsEmptyFillItWithMaterialsFromASupplyTruckOrMiningStation); /* mov eax, 0x101b2512 */
            ii(0x1015_903a, 5); call(0x1011_5d23, -0x4_331c);           /* call 0x10115d23 */
            ii(0x1015_903f, 2); jmp(0x1015_9053, 0x12); goto l_0x1015_9053; /* jmp 0x10159053 */
        l_0x1015_9041:
            ii(0x1015_9041, 5); mov(ebx, 0x2c);                         /* mov ebx, 0x2c */
            ii(0x1015_9046, 5); mov(edx, 0x1d);                         /* mov edx, 0x1d */
            ii(0x1015_904b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_904e, 5); call(0x1016_3053, 0xa000);              /* call 0x10163053 */
        l_0x1015_9053:
            ii(0x1015_9053, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9055, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9056, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9057, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9058, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9059, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_905a, 1); ret();                                  /* ret */
        }
    }
}
